package com.example.appinvestmentnow;

import android.content.Context;
import android.os.StrictMode;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class conexao {
    /**
     * METODO DE CONEXAO
     */
    public static Connection conectar(Context ctx) {
        /** OBJETO DE CONEXÃO*/
        Connection conn = null;
        try {
            /** ADICIONAR POLITICA DE CRIAÇÃO DE THREADS */
            StrictMode.ThreadPolicy politica;
            politica = new StrictMode.ThreadPolicy.Builder().permitAll().build();
            StrictMode.setThreadPolicy(politica);

            /** VERIFICANDO SE O DRIVER DE CONEXÃO ESTÁ NO PROJETO */
            Class.forName("net.sourceforge.jtds.jdbc.Driver");

            /** CRIANDO CONEXÃO COM BANCO*/
            conn = DriverManager.getConnection("jdbc:jtds:sqlserver://192.168.0.117;databaseName=INVESTMENTNOW;user=sa;password=3135;");


        } catch (SQLException e) {
            e.getMessage();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
        return conn;

    }
}
