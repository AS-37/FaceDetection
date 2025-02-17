﻿
namespace Alexandre.Soares.FaceDetection;

public record FaceDetectionResult
{
    public byte[] ImageData { get; set; }
    public IList<ObjectDetectionPoint> Points { get; set; }
}

public record ObjectDetectionPoint
{
    public double X { get; set; }
    public double Y { get; set; }

}