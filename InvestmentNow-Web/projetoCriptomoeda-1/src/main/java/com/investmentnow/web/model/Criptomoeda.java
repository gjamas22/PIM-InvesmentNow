package com.investmentnow.web.model;

import java.io.Serializable;
import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

@Entity
@Table(name="Criptomoeda")
public class Criptomoeda implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	
	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Long Id;
	
	private String nomeMoeda;
	
	private Double valorMoeda;
	
	@Temporal(TemporalType.DATE)
	private Date dataEntrada;
	
	public Long getId() {
		return Id;
	}
	
	public void setId(Long Id) {
		this.Id = Id;
	}
	 
	public String getNomeMoeda() {
		return nomeMoeda;
	}
	
	public void setNomeMoeda(String nomeMoeda) {
		this.nomeMoeda = nomeMoeda;
	}

	public Double getValorMoeda() {
		return valorMoeda;
	}

	public void setValorMoeda(Double valorMoeda) {
		this.valorMoeda = valorMoeda;
	}

	public Date getDataEntrada() {
		return dataEntrada;
	}

	public void setDataEntrada(Date dataEntrada) {
		this.dataEntrada = dataEntrada;
	}
}
