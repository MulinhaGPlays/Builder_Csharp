namespace Food.Builder.Director
{
    public class Director : IDirector
    {
        private MainBuilder builder = new MainBuilder();

        public void setBuilder()
        {
            builder.Reset();
        }

        public void IniciateBuilder()
        {
            builder.MakePrincipal();
            builder.MakeIntermediare();
            builder.MakeFinale();
        }
    }
}
