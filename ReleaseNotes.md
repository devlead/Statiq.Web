# 0.11.0

- Feature - New **Download** module for downloading content during generation (#68 and #75, thanks @dodyg)
- Feature - New **AnalyzeCSharp** module that performs code analysis on C# source files, including XML documentation comments (#70)
- Feature - New **ReadProject** module that loads all the source files referenced in an MSBuild project (#70)
- Feature - New **ReadSolution** module that loads all the source files referenced in an MSBuild solution (#70)
- Feature - Added `WithoutExtensions()` to CopyFiles to make it easier to specify which files to copy
- Feature - Added additional `IExecutionContext.GetNewDocument()` overloads
- Refactoring - Moved `Crc32` to `Wyam.Common` so other module libraries can also use it
- Fix - NuGet support now considers .NET 4.6 packages when resolving libraries
- Fix - Console application now exists with a non-zero error code so automated builds can be aborted if something goes wrong
- Refactoring - Additional trace output for debugging, especially in NuGet resolve process
- Refactoring - Better example test fixture (thanks @yetanotherchris)
- Refactoring - Moved `Wyam.Common` types to appropriate nested namespaces
- Feature - Added `WithMatchOnlyWholeWord()` to AutoLink module (#80, thanks @LokiMidgard)
- Feature - New **HtmlEscape** module for escaping HTML characters (#81, thanks @LokiMidgard)
- Feature - Additional `ToLookup()`, `ToDocumentDictionary()`, and `ToDictionary()` extension methods for `IDocumentCollection` (#82)
- Feature - Added new `Execute()` constructor to Execute module that only gets evaluated once per pipeline (#83, thanks @LokiMidgard)
- Feature - New **GitCommits** and **GitContributors** modules for getting information from Git repositories (#84, thanks @LokiMidgard)
- Feature - New **ConcatBranch** module for branching and then concatenating the output (#87, thanks @LokiMidgard)
- Feature - New **DirectoryMeta** module for applying metadata supplied for an entire directory to all documents sourced from that directory (#86, thanks @LokiMidgard)
- Fix - Fixed several file locking issues (#92)
- Feature - Performance boost by using parallel disposal at the end of pipelines
- Feature - Added `ThenBy()` to OrderBy module (#101, thanks @LokiMidgard)
- Feature - Can now output the config script files the way Roslyn sees them (after adding modules, etc.) for debugging purposes using the `--output-scripts` flag (#99)
- Feature - New `FileName` module for generating SEO-friendly file names (#99, #104, and #107, thanks @yetanotherchris)
- Feature - Added `UseWriteMetadata()` to WriteFiles module to control if metadata values are used for file destination (#106)
- Feature - Default for FrontMatter module is now to ignore delimiter(s) if on the first line
- Feature - All configured namespaces are added as `IExecutionContext.Namespaces` for other code generating modules to use
- Feature - WriteFiles module now sets relative path information metadata (#111, thanks @reliak)
- Feature - New **Sitemap** module to generate standards-compliant sitemap files (#113, thanks @reliak)
- Feature - New **Xmp** module to import XMP encoded metadata (#114, thanks @LokiMidgard)
- Feature - Updates to CopyFiles for better path handling (#116, thanks @reliak)
- Feature - New **SearchIndex** module to generate Lunr.js compliant search indexes (#118, thanks @reliak)
- Feature - New **Switch** module to provide `switch` statement like control for a pipeline (#120, thanks @reliak)
- Feature - Added `IgnoreEmptyContent()` to WriteFiles module to ignore empty files (#117)
- Feature - New **Xslt** module to apply XSLT transformations (#126, thanks @LokiMidgard)
- Feature - New **CsvToHtml** and **ExcelToCsv** modules for working with tabular data (#132, thanks @LokiMidgard)
- Refactoring - Removed static helper methods in `MetadataHelper` and replaced with `MetadataItem` and `MetadataItems` classes to make working with metadata easier
- Refactoring - Renamed `Wyam.Core.MetadataKeys` to `Keys` and moved to `Wyam.Common` for common access (#131).