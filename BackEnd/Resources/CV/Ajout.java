package com.example.atelier5;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Ajout extends AppCompatActivity implements View.OnClickListener {
    private EditText edit_nom;
            private EditText edit_prenom;
    private  EditText edit_tel;
    private Button btn_valider;
    private Personne personne;
    @Override
    protected void onCreate(Bundle savedInstanceState) {

            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_ajout);
            init();
            if (getIntent().getSerializableExtra("personne") != null)
                personne = (Personne) getIntent().getSerializableExtra("personne");
            if (personne != null) {
                edit_nom.setText(personne.getNom());
                edit_prenom.setText(personne.getPrenom());
                edit_tel.setText(personne.getTel()+"");

            }


    }
    public void init(){
        edit_nom=findViewById(R.id.edit_nom);
        edit_prenom=findViewById(R.id.edit_prenom);
        edit_tel=findViewById(R.id.edit_tel);
        btn_valider=findViewById(R.id.btn_valider);
        btn_valider.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        try{
        switch (v.getId()) {
            case R.id.btn_valider:
                if(personne==null) {
                    personne = new Personne(edit_nom.getText().toString(), edit_prenom.getText().toString(), Integer.parseInt(edit_tel.getText().toString()));
                    Intent intent=new Intent();
                    intent.putExtra("personne",personne);
                    setResult(RESULT_OK,intent);
                    finish();
                }
                else{
                    personne.setNom(edit_nom.getText().toString());
                    personne.setPrenom( edit_prenom.getText().toString());
                    personne.setTel(Integer.parseInt(edit_tel.getText().toString()));
                    Intent intent=new Intent();
                    intent.putExtra("personne",personne);
                    setResult(RESULT_OK,intent);
                    finish();
                }

                break;
        }}
        catch (Exception e){}
    }
}
