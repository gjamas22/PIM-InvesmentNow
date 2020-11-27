package com.example.appinvestmentnow;

public class Cliente {
    private int id;
    private String nome;
    private String cpf;
    private String celular;
    private String senha;
    private String email;

    public Cliente(String nome, String email, String cpf, String celular, String senha) {
        this.nome = nome;
        this.cpf = cpf;
        this.celular = celular;
        this.senha = senha;
        this.email = email;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getCelular() {
        return celular;
    }

    public void setCelular(String telefone) {
        this.celular = telefone;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Cliente() {
        this.id = id;
        this.senha = senha;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }

}
