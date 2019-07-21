using System;


namespace R5T.Code.VisualStudio
{
    /// <summary>
    /// A combination of build configuration and platform target specifies a solution build configuration.
    /// </summary>
    public class SolutionBuildConfiguration
    {
        public BuildConfiguration BuildConfiguration { get; set; }
        public PlatformTarget PlatformTarget { get; set; }
    }
}
