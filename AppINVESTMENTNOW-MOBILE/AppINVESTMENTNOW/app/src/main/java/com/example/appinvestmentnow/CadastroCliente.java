package com.example.appinvestmentnow;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

import com.google.android.material.snackbar.Snackbar;

public class CadastroCliente extends AppCompatActivity {
    EditText edtNome, edtEmail, edtCPF, edtSenha, edtTel;
    Button btnCadastro;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadastro_cliente);
        btnCadastro = findViewById(R.id.btnCadastrar);
        edtNome = findViewById(R.id.edtNome);
        edtCPF = findViewById(R.id.edtCPF);
        edtTel = findViewById(R.id.edtTelefone);
        edtSenha = findViewById(R.id.edtSenha);
        edtEmail = findViewById(R.id.edtEmail);

        btnCadastro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                /** Chamar o cadastro */
                Cliente cli = new Cliente(edtNome.getText().toString(), edtEmail.getText().toString(), edtCPF.getText().toString(),
                        edtTel.getText().toString(), edtSenha.getText().toString());
                int res = ClienteDAO.inserirCliente(cli, getBaseContext());
                if (res <= 0) {
                    Snackbar.make(btnCadastro, "Falha ao realizar o cadastro", Snackbar.LENGTH_LONG).show();
                } else {
                    Snackbar.make(btnCadastro, "Cadastro Realizado com Sucesso", Snackbar.LENGTH_LONG).show();
                }
            }
        });
    }
}