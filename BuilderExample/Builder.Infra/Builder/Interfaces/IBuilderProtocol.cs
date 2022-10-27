namespace Builder.Infra.Interfaces
{
    public interface IBuilderProtocol
    {
        public void Reset();
        public void MakePrincipal();
        public void MakeIntermediare();
        public void MakeFinale();
    }
}
