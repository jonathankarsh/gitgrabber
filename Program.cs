using System;
using LibGit2Sharp;

namespace gitgrabber
{
    class Program
    {
        static void Main(string[] args) {
            var path = Repository.Clone("https://github.com/jonathankarsh/latlong", "./latlong");
            var repo = new Repository(path);
            foreach (var commit in repo.Commits) {
                Console.WriteLine("commit: {0} {1}", commit.Sha, commit.MessageShort);
            }
        }
    }
}
