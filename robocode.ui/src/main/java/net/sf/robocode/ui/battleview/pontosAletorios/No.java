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
public class No {
    No proximo = null;
    No anterior = null;
    int pontos[] = new int[2];

    public No(){

    }
    public No(int x, int y){
        pontos[0] = x;
        pontos[1] = y;
    }

    public int[] getPontos() {
        return pontos;
    }
    
    public No getProximo(){
        return proximo;
    }
}
