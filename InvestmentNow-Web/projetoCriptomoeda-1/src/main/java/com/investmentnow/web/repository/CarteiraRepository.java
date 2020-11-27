package com.investmentnow.web.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.investmentnow.web.model.Carteira;

public interface CarteiraRepository extends JpaRepository<Carteira, Long> {

}
