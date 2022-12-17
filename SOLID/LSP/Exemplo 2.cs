namespace SOLID.LSP
{
    public class Pato
    {
        public void QuaQua();
        public void Voa();
        public void Nada();
    }

    public class PatoDeBorracha : Pato
    {
        //Pato de borracha não voa, tem que ser um método que não faz nada
        //O que fere LSP
    }
}
