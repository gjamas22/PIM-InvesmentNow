package com.investmentnow.web.repository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import com.investmentnow.web.model.Cliente;

public interface ClienteRepository extends JpaRepository<Cliente, Long> {

	@Query("from Cliente where email=?1")
	public List<Cliente> buscarClienteEmail(String email);
}
