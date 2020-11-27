package com.investmentnow.web.model;

import java.io.Serializable;
import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToOne;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

@Entity
@Table(name = "Transacao")
public class Transacao implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long Id;

	@OneToOne
	private Criptomoeda criptomoeda;

	@OneToOne
	private Carteira carteira;

	@OneToOne
	private Compra compra;

	private Double valorInvestido=0.;

	private Double quantidadeMoeda=0.;

	private Double valorUnitario=0.;

	@Temporal(TemporalType.TIMESTAMP)
	private Date dataTransacao;

	public Criptomoeda getCriptomoeda() {
		return criptomoeda;
	}

	public void setCriptomoeda(Criptomoeda criptomoeda) {
		this.criptomoeda = criptomoeda;
	}

	public Compra getCompra() {
		return compra;
	}

	public void setCompra(Compra compra) {
		this.compra = compra;
	}

	public Carteira getCarteira() {
		return carteira;
	}

	public void setCarteira(Carteira carteira) {
		this.carteira = carteira;
	}

	public Double getValorInvestido() {
		return valorInvestido;
	}

	public void setValorInvestido(Double valorInvestido) {
		this.valorInvestido = valorInvestido;
	}

	public Double getQuantidadeMoeda() {
		return quantidadeMoeda;
	}

	public void setQuantidadeMoeda(Double quantidadeMoeda) {
		this.quantidadeMoeda = quantidadeMoeda;
	}

	public Date getDataTransacao() {
		return dataTransacao;
	}

	public void setDataTransacao(Date dataTransacao) {
		this.dataTransacao = dataTransacao;
	}

	public Double getValorUnitario() {
		return valorUnitario;
	}

	public void setValorUnitario(Double valorUnitario) {
		this.valorUnitario = valorUnitario;
	}

}
