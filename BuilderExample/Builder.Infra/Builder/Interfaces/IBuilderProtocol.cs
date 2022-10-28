namespace Builder.Infra.Interfaces
{
    public interface IBuilderProtocol<TSource>
    {
        public TSource Reset();
        public TSource MakePrincipal();
        public TSource MakeIntermediare();
        public TSource MakeFinale();
    }
}
