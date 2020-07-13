namespace builder
{
    public class ConcreteBigHouse: IHouseBuilder
    {
        private BigHouse result = new BigHouse();

        public void Reset(){
            this.result = new BigHouse();
        }

        public void BuildWalls(){
            result.Walls = 5;
        }

        public void BuildGarage(){
            result.HasGarage = true;
        }

        public BigHouse GetResult(){
            return result;
        }

        public override string ToString(){
            return $"total walls: {this.result.Walls} - has garage {this.result.HasGarage}";
        }

    }
}