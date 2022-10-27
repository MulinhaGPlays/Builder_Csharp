namespace Food.Builder.Director
{
    public class Director : IDirector
    {
        private MainBuilder builder = new MainBuilder();

        public Director SetBuilder()
        {
            builder.Reset();
            return this;
        }

        public Director InicializeBuilder()
        {
            builder.MakePrincipal();
            builder.MakeIntermediare();
            builder.MakeFinale();
            return this;
        }
    }
}
