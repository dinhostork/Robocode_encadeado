/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package net.sf.robocode.ui.battleview.pontosAletorios;
import java.util.Random;

/**
 *
 * @author root
 */
public class GeracaoInsercao {
    public ListaManager l1 = new ListaManager(); // criação da lista
    
    
    public int[] geraPontosAleatorios(int tamanhoArena){
        Random gerador = new Random();
        int pontos[] = new int[2];
        pontos[0] = gerador.nextInt(tamanhoArena);
        pontos[1] = gerador.nextInt(tamanhoArena);
        return pontos;
    }   
    
    public GeracaoInsercao(int arenaSize){
        Random quantidadeDePontos = new Random();
        int qtdPontos = quantidadeDePontos.nextInt(10);
        System.out.println(qtdPontos);
        for(int i = 0; i<qtdPontos; i++){
            int pontos[] = new int[2];
            pontos = geraPontosAleatorios(10);
            l1.inserirPontos(pontos);
        }
    }
    
    
    public void verificaGeraInsere(){
        l1.percorrerLista();
    }
    
    
}
