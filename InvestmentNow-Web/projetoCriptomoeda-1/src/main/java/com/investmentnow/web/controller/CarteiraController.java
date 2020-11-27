package com.investmentnow.web.controller;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

import com.investmentnow.web.model.Carteira;
import com.investmentnow.web.model.Compra;
import com.investmentnow.web.model.Criptomoeda;
import com.investmentnow.web.model.Transacao;
import com.investmentnow.web.repository.CarteiraRepository;
import com.investmentnow.web.repository.CompraRepository;
import com.investmentnow.web.repository.CriptomoedaRepository;

@Controller
public class CarteiraController {

	private List<Transacao> transacao = new ArrayList<Transacao>();

	private Compra compra = new Compra();

	@Autowired
	private CompraRepository compraRepository;

	@Autowired
	private CarteiraRepository carteiraRepository;

	@Autowired
	private CriptomoedaRepository criptomoedaRepository;

	private void calcularTotal() {
		compra.setValorTotal(0.);
		for (Transacao it : transacao) {
			compra.setValorTotal(compra.getValorTotal() + it.getValorInvestido());
		}
	}

	@PostMapping("/admin")
	public ModelAndView cadastrar() {
		ModelAndView mv = new ModelAndView("/Carteira");

		return mv;
	}

	@GetMapping("/depositar")
	public ModelAndView depositar(Carteira carteira) {
		ModelAndView mv = new ModelAndView("/depositar");
		mv.addObject("carteira", carteira);
		return mv;
	}

	@PostMapping("/depositar")
	public ModelAndView salvar(@Valid Carteira carteira, BindingResult result) {

		if (result.hasErrors()) {
			return depositar(carteira);
		}
		carteiraRepository.saveAndFlush(carteira);

		return depositar(new Carteira());
	}

	@RequestMapping("/comprarmoeda")
	public ModelAndView acesso() {
		ModelAndView mv = new ModelAndView("/comprar");
		List<Criptomoeda> criptomoeda = criptomoedaRepository.findAll();
		mv.addObject("criptomoeda", criptomoeda);
		return mv;
	}

	@RequestMapping("/carrinho")
	public ModelAndView chamarCarrinho() {
		ModelAndView mv = new ModelAndView("/Carrinho");
		calcularTotal();
		mv.addObject("compra", compra);
		mv.addObject("transacao", transacao);
		return mv;
	}

	@RequestMapping("/finalizar")
	public ModelAndView finalizarCompra() {
		ModelAndView mv = new ModelAndView("Finalizar");
		calcularTotal();
		mv.addObject("compra", compra);
		mv.addObject("transacao", transacao);
		return mv;
	}

	@PostMapping("/finalizar/confirmar")
	public ModelAndView confirmarCompra(String formaPagamento) {
		ModelAndView mv = new ModelAndView("mensagemFinalizou");
		compraRepository.saveAndFlush(compra);

		for (Transacao c : transacao) {
			c.setCompra(compra);
			compraRepository.saveAndFlush(compra);
		}
		transacao = new ArrayList<>();
		compra = new Compra();
		return mv;
	}

	@RequestMapping("/adicionarCarrinho/{id}")
	public ModelAndView adicionarCarrinho(@PathVariable Long id) {
		ModelAndView mv = new ModelAndView("Carrinho");

		Optional<Criptomoeda> prod = criptomoedaRepository.findById(id);
		Criptomoeda criptomoeda = prod.get();

		int controle = 0;
		for (Transacao it : transacao) {
			if (it.getCriptomoeda().getId().equals(criptomoeda.getId())) {
				it.setQuantidadeMoeda(it.getQuantidadeMoeda() + 1);
				it.setValorInvestido(0.);
				it.setValorInvestido(it.getValorInvestido() + (it.getQuantidadeMoeda() * it.getValorUnitario()));
				controle = 1;
				break;
			}
		}
		if (controle == 0) {
			Transacao item = new Transacao();
			item.setCriptomoeda(criptomoeda);
			item.setValorUnitario(criptomoeda.getValorMoeda());
			item.setQuantidadeMoeda(item.getQuantidadeMoeda() + 1);
			item.setValorInvestido(item.getValorInvestido() + (item.getQuantidadeMoeda() * item.getValorUnitario()));
			calcularTotal();
			transacao.add(item);
		}
		calcularTotal();
		mv.addObject("compra", compra);
		mv.addObject("transacao", transacao);
		return mv;
	}

	@RequestMapping("/alterarQuantidade/{id}/{acao}")
	public ModelAndView alterarQuantidade(@PathVariable Long id, @PathVariable Integer acao) {
		ModelAndView mv = new ModelAndView("Carrinho");

		for (Transacao it : transacao) {
			if (it.getCriptomoeda().getId().equals(id)) {
				if (acao.equals(1)) {
					it.setQuantidadeMoeda(it.getQuantidadeMoeda() + 1);
					it.setValorInvestido(0.);
					it.setValorInvestido(it.getValorInvestido() + (it.getQuantidadeMoeda() * it.getValorUnitario()));
					calcularTotal();
				} else if (acao == 0) {
					it.setQuantidadeMoeda(it.getQuantidadeMoeda() - 1);
					it.setValorInvestido(0.);
					it.setValorInvestido(it.getValorInvestido() + (it.getQuantidadeMoeda() * it.getValorUnitario()));
					calcularTotal();
				}
				break;

			}
		}
		calcularTotal();
		mv.addObject("compra", compra);
		mv.addObject("transacao", transacao);
		return mv;
	}

	@RequestMapping("/removerEvento/{id}")
	public ModelAndView removerEventoCarrinho(@PathVariable Long id) {
		ModelAndView mv = new ModelAndView("Carrinho");

		for (Transacao it : transacao) {
			if (it.getCriptomoeda().getId().equals(id)) {
				transacao.remove(it);
				calcularTotal();
				break;

			}
		}
		calcularTotal();
		mv.addObject("compra", compra);
		mv.addObject("transacao", transacao);
		return mv;
	}
}
