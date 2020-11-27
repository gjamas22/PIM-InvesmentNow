package com.example.appinvestmentnow;

import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

import android.os.Bundle;

import com.google.android.material.bottomnavigation.BottomNavigationView;

public class pgnInicial extends AppCompatActivity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pgn_inicial);

        /** BARRA DE NAVEGAÇÃO */

        BottomNavigationView navView = findViewById(R.id.bnvMenu);
        AppBarConfiguration appBarConfiguration = new AppBarConfiguration.Builder(R.id.inicio, R.id.list).build();
        NavController navController = Navigation.findNavController(this, R.id.fragHost);
        NavigationUI.setupActionBarWithNavController(this, navController, appBarConfiguration);
        NavigationUI.setupWithNavController(navView, navController);
    }
}