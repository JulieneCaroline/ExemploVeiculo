/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package classe_objetos;

/**
 *
 * @author Gabiru
 * 
 * 
 * Este código é um exemplo de como se cria uma classe e se instancia um objeto,
 * Tambem neste arquivo tem exemplos de como se usar os métodos para acessar 
 * 
 */



public class Classe_objetos {

    /**
     * @param args the command line arguments
     */
    //declarando classe
    static public class Computador{
    //criando os atributos
    private String processador;
    private String memoria;
    private String marca;
    private String monitor;
    
    
    //criando os métodos
    public String getProcessador(){
        return processador;
    }
    public String getMemoria(){
        return memoria;
    }
    public String getMarca(){
        return marca;
    }
    public String getMonitor(){
        return monitor;
    }
    public void setProcessador(String processador){
        this.processador = processador;
    }
    public void setMemoria(String memoria){
        this.memoria = memoria;
    }
    public void setMarca(String marca){
        this.marca = marca;
    }
    public void setMonitor(String monitor){
        this.monitor = monitor;
    }
        
    }
    public static void main(String[] args) {
        // TODO code application logic here
        //instancia o objeto
        Computador pcMaria = new Computador();
        
        //utilizando os objetos por meio dos métodos
        pcMaria.setProcessador("Celeron800");
        pcMaria.setMemoria("166");
        pcMaria.setMarca("positivo");
        pcMaria.setMonitor("Sansung");
        
        System.out.println("O processador é: "+pcMaria.getProcessador());
        System.out.println("A memória é: "+pcMaria.getMemoria());
        System.out.println("A marca é: "+pcMaria.getMarca());
        System.out.println("O monitor é: "+pcMaria.getMonitor());
        

    }
    
}
