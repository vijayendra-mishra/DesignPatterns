namespace DesignPatterns.FactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            return shapeType.ToLower() switch
            {
                "circle" => new Circle(),
                "square" => new Square(),
                "rectangle" => new Rectangle(),
                _ => null,
            };
        }

    }
}
