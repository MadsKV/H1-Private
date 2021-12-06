using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;

namespace GUI___Webserver
{
    class Program
    {
        static void Main(string[] args)
        {

            startWebserver();

        }
        static void startWebserver()

        {

            IPAddress ip = IPAddress.Parse("127.0.0.1");

            TcpListener server = new TcpListener(ip, 8080);

            server.Start();

            Console.WriteLine("Listening on port 8080");

            while (true)

            {

                TcpClient client = server.AcceptTcpClient();

                Console.WriteLine("Client connected");



                NetworkStream stream = client.GetStream();



                byte[] buffer = new byte[1024];

                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                string request = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);

                Console.WriteLine(request);

                string[] words = request.Split(" ");

                string responseHTML = " ";

                string contentype = " ";


                if (words.Length == 1)
                {
                    continue;
                }
                  
                if (words[1] == "/")
                {
                    responseHTML = File.ReadAllText("Index.html");
                    contentype = "text/html";
                }

                else if (words [1] == "/Stylesheet.css")
                {
                    responseHTML = File.ReadAllText("Stylesheet.css");
                    contentype = "text/css";
                }
                else if (words[1] == "/JavaScript1.js")
                {
                    responseHTML = File.ReadAllText("JavaScript.js");
                    contentype = "text/JavaScript";
                }
                else
                {
                    responseHTML = File.ReadAllText("Index.html");
                }

                int responseHTMLLength = responseHTML.Length;

                string response = $"HTTP/1.1 200 OK\r\nDate: Mon, 27 Jul 2009 12:28:53 GMT\r\nServer: Apache/2.2.14 (Win32)\r\nLast-Modified: Wed, 22 Jul 2009 19:15:56 GMT\r\nContent-Length: {responseHTMLLength}\r\nContent-Type: {contentype}\r\nConnection: Closed\r\n\r\n" + responseHTML;

                byte[] responseBytes = System.Text.Encoding.UTF8.GetBytes(response);

                stream.Write(responseBytes);

                stream.Flush();

                client.Close();

            }



        }
    }
}