using System;
using QRCoder;

namespace az_function_qrcode.Application;

public static class QrCode
{
    // Method to generate the QR Code as Base64
    public static string GenerateQrCodeBase64(string content)
    {
        using var qrGenerator = new QRCodeGenerator();
        using var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
        using var qrCode = new PngByteQRCode(qrCodeData);
        var qrCodeImage = qrCode.GetGraphic(20);
    
        return Convert.ToBase64String(qrCodeImage);
    }
}