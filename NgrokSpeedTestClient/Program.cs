using WebSocketSharp;

WebSocket webSocket = new WebSocket("wss://24f0-2404-7a81-80c0-d200-d199-239a-aba-b917.jp.ngrok.io/");

webSocket.OnClose += (sender, e) => Console.WriteLine("close");
webSocket.OnError += (sender, e) => Console.WriteLine("error");
webSocket.OnMessage += (sender, e) =>
{
    Console.WriteLine("message");
    webSocket.Send("hoge");
};
webSocket.OnOpen += (sender, e) =>
{
    Console.WriteLine("open");
    webSocket.Send("hoge");
};

webSocket.Connect();
webSocket.Send("hoge");

while (true) ;