class Program
{
    static void Main()
    {
        //cria-se um personagem p
        Personagem p1, p2;

        p1 = new Personagem();
        p2 = new Personagem();

        //atribui o valor 100 ao atributo Energia, da classe Personagem
        p1.setEnergia(100);
        p2.setEnergia(80);

        //mostra o valor setado no atribulo Energia
        Console.Write("Personagem 1:\n");
        Console.Write("Energia: " + p1.getEnergia() + "\n");
        Console.Write("\n\n");
        
        //mostra o valor setado no atribulo Energia, sofrendo manipulacao 
        Console.Write("Personagem 2:\n");
        Console.Write("Energia: " + p2.getEnergia() + "\n");
        p2.levarSoco('r');
        Console.Write("Levou um soco fraco\n");
        Console.Write("Energia: " + p2.getEnergia() + "\n");
        p2.levarSoco('m');
        Console.Write("Levou um soco medio\n");
        Console.Write("Energia: " + p2.getEnergia() + "\n");
        p2.levarSoco('f');
        Console.Write("Levou um soco forte\n");
        Console.Write("Energia: " + p2.getEnergia() + "\n");
        }
}

class Personagem
{
    private int energia;
    //private Vetor3 posicao;

//setters - grava dado no atribulo Energia
    public void setEnergia(int e)
    {
        energia = e;
    }
    public void levarSoco(char f)
    {
        switch (f)
        {
        case 'r': energia = energia - 5; break;
        case 'm': energia = energia - 10; break;
        case 'f': energia = energia - 20; break;
        }
    }
    public void pular()
    {

    }
//getters - ler valor do atributo Energia
    public int getEnergia()
    {
        return energia;
    }
}