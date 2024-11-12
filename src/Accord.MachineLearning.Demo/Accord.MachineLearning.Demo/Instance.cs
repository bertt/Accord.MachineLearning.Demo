
public class Instance
{
    public Instance()
    {
        Scale = 1;
    }
    public Wkx.Geometry Position { get; set; }

    public double Scale { get; set; }

    public double[] ScaleNonUniform { get; set; }

    public double Rotation { get; set; }

    public Array Tags { get; set; }

    public object Model { get; set; }

    public double Yaw { get; set; }

    public double Pitch { get; set; }
    public double Roll { get; set; }
}
