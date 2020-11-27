package com.investmentnow.web.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.investmentnow.web.model.Transacao;

public interface TransacaoRepository extends JpaRepository<Transacao, Long>{

}
