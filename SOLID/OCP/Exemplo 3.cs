namespace SOLID.OCP
{
    public class Post
    {
        public void Curtir(int postId)
        {

        }
    }

    //E se agora tiver uma outra reação?

    //Errado
    public class Post
    {
        public void Curtir(int postId)
        {

        }

        public void Gratidao(int postId)
        {

        }
    }


    public class Post
    {
        public void Reagir(IReact react, int postId)
        {
            react.React();
        }
    }

}
