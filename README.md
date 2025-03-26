# qrify 🎯  
**A simple and fast serverless QR Code generator API**  

qrify is a lightweight, serverless API designed to generate QR codes on demand. It provides an easy and scalable way to create QR codes for URLs, text, or any other data format without the need for managing servers.  

## 🚀 Features  
✅ **Serverless & Scalable** – Runs on AWS Lambda, Firebase Functions, or any serverless platform.  
✅ **Fast & Lightweight** – Generates QR codes in milliseconds.  
✅ **Easy to Use** – Just send a simple HTTP request and get a QR code in return.  
✅ **Supports Multiple Formats** – Get QR codes in PNG, SVG, or Base64 formats.  

## 🔧 How It Works  
1. **Send a POST request** with the content you want to encode.  
2. **Receive a QR code** as an image or Base64 string.  
3. **Use it anywhere** – websites, apps, marketing materials, and more!  

## 📌 Example Request  
```http

curl --location 'https://localhost:5000/api/az_qrcode?code=az-function-code&content=Gian'

```


## 📌 Example Response  
```http
{
  "qr_image": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUg..."
}
```

## 🎯 Use Cases

🔹 Dynamic QR codes for websites and apps.
🔹 Instant QR generation for digital payments.
🔹 Marketing campaigns with trackable QR codes.
🔹 Contactless business cards.