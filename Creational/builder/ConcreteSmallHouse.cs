namespace builder
{
    public class ConcreteSmallHouse: IHouseBuilder
    {
        private SmallHouse result = new SmallHouse();

        public void Reset(){
            this.result = new SmallHouse();
        }
        public void BuildWalls(){
            result.Walls = 3;
        }

        public void BuildGarage(){
            result.HasGarage = true;
        }

        public SmallHouse GetResult(){
            return result;
        }

        public override string ToString(){
            return $"total walls: {this.result.Walls} - has garage {this.result.HasGarage}";
        }
    }
}