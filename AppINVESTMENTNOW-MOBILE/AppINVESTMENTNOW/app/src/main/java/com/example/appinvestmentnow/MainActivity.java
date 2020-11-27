package com.example.appinvestmentnow;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;


public class MainActivity extends AppCompatActivity {
    EditText tLogin, tSenha;
    Button btLogin, btRegistro;
    String Finder;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        inicializarComponentes();

        btLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Cliente ncli = ClienteDAO.pesquisarLogin(tLogin.getText().toString(), tSenha.getText().toString(), getBaseContext());
                if (ncli != null) {
                    Finder = tLogin.getText().toString();
                    Intent it = new Intent(MainActivity.this, pgnInicial.class);
                    startActivity(it);
                    Toast.makeText(getApplicationContext(), "Login Realizado com sucesso", Toast.LENGTH_SHORT).show();
                } else {
                    Toast.makeText(getApplicationContext(), "Usuario ou senha Incorretos", Toast.LENGTH_SHORT).show();
                }
            }
        });

        btRegistro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent it = new Intent(MainActivity.this, CadastroCliente.class);
                startActivity(it);
            }

        });
    }

    private void alert(String s) {
        Toast.makeText(this, s, Toast.LENGTH_LONG).show();
    }

    private void inicializarComponentes() {
        btLogin = findViewById(R.id.btLogin);
        tLogin = findViewById(R.id.tLogin);
        tSenha = findViewById(R.id.tSenha);
        btRegistro = findViewById(R.id.btRegistro);
    }
}