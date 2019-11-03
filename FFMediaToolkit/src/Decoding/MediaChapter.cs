﻿namespace FFMediaToolkit.Decoding
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a chapter in a media file.
    /// </summary>
    public class MediaChapter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaChapter"/> class.
        /// </summary>
        /// <param name="start">The starting time of this chapter.</param>
        /// <param name="end">The ending time of this chapter.</param>
        /// <param name="metadata">This chapter's metadata.</param>
        internal MediaChapter(TimeSpan start, TimeSpan end, Dictionary<string, string> metadata)
        {
            Start = start;
            End = end;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets the start time of this chapter.
        /// </summary>
        public TimeSpan Start { get; }

        /// <summary>
        /// Gets the end time of this chapter.
        /// </summary>
        public TimeSpan End { get; }

        /// <summary>
        /// Gets the metadata for this chapter (such as name).
        /// </summary>
        public Dictionary<string, string> Metadata { get; }
    }
}