namespace builder
{
    public class HouseDirector
    {
        private IHouseBuilder _builder;
        
        public IHouseBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalHouse()
        {
            this._builder.BuildWalls();
        }
        
        public void BuildFullFeaturedHouse()
        {
            this._builder.BuildWalls();
            this._builder.BuildGarage();
        }
    }
}