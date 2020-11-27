package com.example.appinvestmentnow;

import android.content.Context;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class ClienteDAO {
    /**
     * Metodo de Cadastro
     */
    public static int inserirCliente(Cliente cliente, Context ctx) {
        int resposta = 0;

        try {
            PreparedStatement pst = conexao.conectar(ctx).prepareStatement("insert into Cliente (nome, email, cpf, celular, senha)" +
                    "values(?,?,?,?,?)");
            pst.setString(1, cliente.getNome());
            pst.setString(2, cliente.getEmail());
            pst.setString(3, cliente.getCpf());
            pst.setString(4, cliente.getCelular());
            pst.setString(5, cliente.getSenha());

            resposta = pst.executeUpdate();
        } catch (Exception e) {
            e.getMessage();

        }
        return resposta;
    }

    /**
     * Metodo de Pesquisa
     */
    public static List<Transacao> pesquisarInvestimentos(Context ctx) {
        /** Listagem de Transações */
        List<Transacao> lista = null;
        PreparedStatement pst;
        try {
            pst = conexao.conectar(ctx).prepareStatement("Select codTransacao, valor_investido," +
                    " quantidade_moedas, codCarteira, codMoeda, codTarifa, codCliente" +
                    " from Transacao order by codTransacao");
            /** Execução da pesquisa e retorno */
            ResultSet res = pst.executeQuery();

            lista = new ArrayList<Transacao>();
            while (res.next()) {
                lista.add(new Transacao(res.getInt(1), res.getBigDecimal(2),
                        res.getBigDecimal(3), res.getInt(4),
                        res.getInt(5), res.getInt(6),res.getInt(7)));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return lista;
    }

    public static List<Transacao> pesquisarInvestimentos(String dado, Context ctx) {
        /** Listagem de Transações */
        List<Transacao> lista = null;
        PreparedStatement pst;
        try {
            pst = conexao.conectar(ctx).prepareStatement("Select codTransacao, valor_investido," +
                    " quantidade_moedas, codCarteira,codMoeda,codTarifa, codCliente" +
                    " from Transacao where codTransacao like '%" + dado + "%' order by codTransacao");
            /** Execução da pesquisa e retorno */
            ResultSet res = pst.executeQuery();
            lista = new ArrayList<Transacao>();
            while (res.next()) {
                lista.add(new Transacao(res.getInt(1), res.getBigDecimal(2),
                        res.getBigDecimal(3), res.getInt(4),
                        res.getInt(5), res.getInt(6),res.getInt(7)));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return lista;
    }

    /**
     * Metodo de Login
     */
    public static Cliente pesquisarLogin(String email, String senha, Context ctx) {
        try {
            PreparedStatement pst = conexao.conectar(ctx).prepareStatement("select * from Cliente where email = ? and senha = ?");
            pst.setString(1, email);
            pst.setString(2, senha);
            ResultSet result = pst.executeQuery();

            while (result.next()) {

                Cliente objLogin = new Cliente();
                objLogin.setEmail(result.getString(1));
                objLogin.setSenha(result.getString(2));
                return objLogin;
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }

}