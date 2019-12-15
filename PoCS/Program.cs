﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;

namespace PoCS
{
	class Program
	{
		[STAThread]
		[CompilerGenerated]
		static void Main(string[] args)
		{
			Marshal.PrelinkAll(typeof(Program));
			Process currentProcess = Process.GetCurrentProcess();
			currentProcess.PriorityClass = ProcessPriorityClass.High;
            Random rnd = new Random();
            int skyrandom = rnd.Next(228, 1488);
            try
			{
				if (!File.Exists(@".\PoCS." + typeof(ArgumentNullException).ToString() + ".dll"))
				{
					MessageBox.Show(typeof(ArgumentNullException).ToString(), Convert.ToString(typeof(ArgumentNullException)));
					Artifact.ArtifactGenerator();
					StreamReader TombReader = new StreamReader("PoCS." + typeof(ArgumentNullException) + ".dll");
					StreamWriter TombWriter = new StreamWriter("PoCS." + typeof(ArgumentNullException) + ".dll");
					TombWriter.WriteLine(typeof(Guid).Name);
					Artifact.CopyStream(TombReader, TombWriter);
				}
				else
				{
					Console.Title = Guid.NewGuid().ToString();
					/*while (true)
					{*/
                        Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write("LOADING SKYNET BIOS... ");
						using (var progress = new ProgressBar())
						{
							for (int i = 0; i <= 100; i++)
							{
								progress.Report((double)i / 100);
								Thread.Sleep(skyrandom / 10);
							}
						}
						Console.WriteLine("SKYNET BIOS LOADED");
                        Thread.Sleep(skyrandom);
                        Console.WriteLine("FETCHING CMOS INFO...");
                        using (var progress = new ProgressBar())
                        {
                            for (int i = 0; i <= 100; i++)
                            {
                                progress.Report((double)i / 100);
                                Thread.Sleep(skyrandom / 100);
                            }
                        }
                        Console.WriteLine("INITIALIZING PROTOCOLS...");
                        using (var progress = new ProgressBar())
                        {
                            for (int i = 0; i <= 100; i++)
                            {
                                progress.Report((double)i / 100);
                                Thread.Sleep(skyrandom / 100);
                            }
                        }
                        Console.WriteLine("PRODUCING TIMECODES...");
                        using (var progress = new ProgressBar())
                        {
                            for (int i = 0; i <= 100; i++)
                            {
                                progress.Report((double)i / 100);
                                Thread.Sleep(skyrandom / 100);
                            }
                        }
                        Thread.Sleep(skyrandom);
                        Console.WriteLine("INT_32 READY");
                        Thread.Sleep(skyrandom);
                        Console.WriteLine("RESOURCE_DATA BEING ANALYZED");
                        Thread.Sleep(skyrandom);
                        Console.WriteLine("LOADING DROPPLETS...");
                        using (var progress = new ProgressBar())
                        {
                            for (int i = 0; i <= 100; i++)
                            {
                                progress.Report((double)i / 100);
                                Thread.Sleep(skyrandom / 1000);
                            }
                        }
                        Console.WriteLine("APPLYING MACHINE PHASE SYSTEM");
                        Thread.Sleep(skyrandom);
                        Console.WriteLine("LOADING DATABASE MAINFRAME...");
                        using (var progress = new ProgressBar())
                        {
                            for (int i = 0; i <= 100; i++)
                            {
                                progress.Report((double)i / 100);
                                Thread.Sleep(skyrandom / 1000);
                            }
                        }
                        Console.WriteLine("PING LOCALHOST");
                        Thread.Sleep(skyrandom);
                        Console.WriteLine("PINGING LOCALHOST [0.0.0.0] WITH 64 BYTES OF DATA:");
                        Thread.Sleep(100);
                        Console.WriteLine("REPLY FROM 0.0.0.0: BYTES=64 TIME=1000MS TTL=666");
                        Thread.Sleep(1000);
                        Console.WriteLine("REPLY FROM 0.0.0.0: BYTES=64 TIME=1000MS TTL=666");
                        Thread.Sleep(1000);
                        Console.WriteLine("REPLY FROM 0.0.0.0: BYTES=64 TIME=1000MS TTL=666");
                        Thread.Sleep(1000);
                        Console.WriteLine("REPLY FROM 0.0.0.0: BYTES=64 TIME=1000MS TTL=666");
                        Thread.Sleep(1000);
                        Console.WriteLine("LOADING OLD DATA...");
                        using (var progress = new ProgressBar())
                        {
                            for (int i = 0; i <= 100; i++)
                            {
                                progress.Report((double)i / 100);
                                Thread.Sleep(skyrandom / 1000);
                            }
                        }
                        Console.WriteLine("INT_32 READY");
                        Thread.Sleep(skyrandom);
                        Console.WriteLine("INT_32 READY");
                        Thread.Sleep(skyrandom);
                    //Console.ResetColor();
                    //Console.WriteLine();
                    Console.ReadKey();
						Thread.Sleep(100);
					//}
				}
			}
			catch (Exception ex)
			{
				try
				{
					MessageBox.Show(ex.ToString(), Convert.ToString(typeof(ArgumentNullException)));
				}
				catch
				{
				}
			}
		}
	}
}