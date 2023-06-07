// AlgorithmsAndDataStructure 
// Lab 4


using System;
using System.Collections.Generic;

class SongPlaylist
{
    // Use stack to keep track of played songs.
    static Stack<string> historyOfSong = new Stack<string>();

    // Use queue to store upcoming songs in the playlist.
    static Queue<string> songPlaylist = new Queue<string>();

    static void Main()
    {
        Console.WriteLine("\n Welcome to c# Media Player App");

        while (true)
        {
            Console.WriteLine("\n Your commands are: ");
            Console.WriteLine("1. add - Add a song to your playlist");
            Console.WriteLine("2. play - Play the next song in your playlist ");
            Console.WriteLine("3. skip - Skip the next song");
            Console.WriteLine("4. rewind - Rewind one song");
            Console.WriteLine("5. exit - Exit the Media Player");


            Console.WriteLine(" \n Enter a command: ");
            string command = Console.ReadLine().ToLower();


            switch (command)
            {
                case "add":
                    AddSong();
                    break;
                case "play":
                    PlayNextSong();
                    break;
                case "skip":
                    SkipSong();
                    break;
                case "rewind":
                    Rewind();
                    break;
                case "exit":
                    ExitApp();
                    return;  // It will end the jounery of user ;) and exit the app
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
        }
    }

    static void AddSong()
    {
        Console.Write("Enter the name of the song: ");
        string songTitle = Console.ReadLine();
        // add the song into the playlist
        songPlaylist.Enqueue(songTitle);
        Console.WriteLine("Added song: " + songTitle);
    }

    static void PlayNextSong()
    {
        if (songPlaylist.Count > 0)
        {
            // Get the next song from the playlist and remove it from the queue
            string playSong = songPlaylist.Dequeue();
            Console.WriteLine("Now playing: " + playSong);
            // Add the song to the stack
            historyOfSong.Push(playSong);
        }
        else
        {
            Console.WriteLine("\n Your playlist is empty. Please, Add some songs to play :) ");
        }
    }

    static void SkipSong()
    {
        if (songPlaylist.Count > 0)
        {
            // Get the upcoming song from the playlist without removing it
            string upcomingSong = songPlaylist.Peek();
            Console.WriteLine("Skipping: " + upcomingSong);
            // Remove the upcoming song from the playlist
            songPlaylist.Dequeue();
        }
        else
        {
            //Console.WriteLine("Your paylist is empty. Please, Add some songs to skip :) ");
        }
    }

    static void Rewind()
    {
        if (historyOfSong.Count > 0)
        {
            // Get the last played song from the stack and remove it
            string previousSong = historyOfSong.Pop();
            Console.WriteLine("Rewinding to: " + previousSong);
            // Add the previous song back to the playlist
            songPlaylist.Enqueue(previousSong);
        }
        else
        {
            Console.WriteLine("No previous songs to rewind to.");
        }
    }

    static void ExitApp()
    {
        Console.WriteLine("Exiting Media Player. Goodbye!");
    }
}