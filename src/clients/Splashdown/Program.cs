﻿using System;
using System.Threading.Tasks;
using Wyam.App;
using Wyam.Common.Execution;
using Wyam.Core.Modules.Contents;
using Wyam.Core.Modules.Control;
using Wyam.Core.Modules.IO;
using Wyam.Markdown;
using Wyam.Yaml;

namespace Splashdown
{
    public class Program
    {
        // Use with the YamlFrontMatter example from that folder
        // dotnet run --project ..\..\src\clients\Splashdown\Splashdown.csproj -- preview
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .CreateDefault(args)
                .AddPipeline(
                    new ReadFiles("*.md"),
                    new FrontMatter(new Yaml()),
                    new Markdown(),
                    new ReplaceIn("{{CONTENT}}", new ReadFiles("template.html")),
                    new Replace("{{TITLE}}", (doc, _) => doc.Get("Title", "Default Title")),
                    new Replace("{{DESC}}", (doc, _) => doc.Get("Description", "Default Description")),
                    new WriteFiles(".html"))
                .RunAsync();
    }
}
