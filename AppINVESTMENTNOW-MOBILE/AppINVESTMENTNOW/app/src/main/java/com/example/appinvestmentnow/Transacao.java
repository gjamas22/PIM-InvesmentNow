package com.example.appinvestmentnow;

import java.math.BigDecimal;

public class Transacao {
    private Integer codTransacao;
    private BigDecimal valor_investido;
    private BigDecimal quantidade_moedas;
    private Integer codCarteira;
    private Integer codMoeda;
    private Integer codTarifa;
    private Integer codCliente;

    public Transacao(Integer codTransacao, BigDecimal valor_investido, BigDecimal quantidade_moedas, Integer codCarteira,
                     Integer codMoeda, Integer codTarifa, Integer codCliente) {
        this.codTransacao = codTransacao;
        this.valor_investido = valor_investido;
        this.quantidade_moedas = quantidade_moedas;
        this.codCarteira = codCarteira;
        this.codMoeda = codMoeda;
        this.codTarifa = codTarifa;
        this.codCliente = codCliente;

    }

    public Integer getCodTransacao() {
        return codTransacao;
    }

    public void setCodTransacao(Integer codTransacao) {
        this.codTransacao = codTransacao;
    }

    public BigDecimal getValor_investido() {
        return valor_investido;
    }

    public void setValor_investido(BigDecimal valor_investido) {
        this.valor_investido = valor_investido;
    }

    public BigDecimal getQuantidade_moedas() {
        return quantidade_moedas;
    }

    public void setQuantidade_moedas(BigDecimal quantidade_moedas) {
        this.quantidade_moedas = quantidade_moedas;
    }

    public Integer getCodCarteira() {
        return codCarteira;
    }

    public void setCodCarteira(Integer codCarteira) {
        this.codCarteira = codCarteira;
    }

    public Integer getCodMoeda() {
        return codMoeda;
    }

    public void setCodMoeda(Integer codMoeda) {
        this.codMoeda = codMoeda;
    }

    public Integer getCodTarifa() {
        return codTarifa;
    }

    public void setCodTarifa(Integer codTarifa) {
        this.codTarifa = codTarifa;
    }

    public Integer getCodCliente() {
        return codCliente;
    }

    public void setCodCliente(Integer codCliente) {
        this.codCliente = codCliente;
    }
}
