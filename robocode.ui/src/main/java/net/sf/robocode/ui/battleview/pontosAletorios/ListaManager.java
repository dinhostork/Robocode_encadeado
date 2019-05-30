/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package net.sf.robocode.ui.battleview.pontosAletorios;

/**
 *
 * @author root
 */
import java.util.Random;

public class ListaManager {
    public No primeiro = null;
    public No ultimo = null;
    int quantidade = 0;
    
    
 

    
    public void inserirPontos(int [] pontos){
    No atual = new No(pontos[0], pontos[1]);
       if(quantidade == 0){
           primeiro=atual;
           ultimo = atual;
       }else{
           atual.proximo = null;
           ultimo.proximo = atual;
           atual.anterior = ultimo;
           ultimo = atual;
       }
       quantidade++;
    }
    
    
    public void percorrerLista(){
        No atual = getPrimeiro();
        
        }

    public No getPrimeiro() {
        return primeiro;
    }
    
    public int getQtd(){
        return quantidade;
    }
    
}
