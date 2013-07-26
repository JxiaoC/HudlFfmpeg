﻿using System.Collections.Generic;
using Hudl.Ffmpeg.Common;
using Hudl.Ffmpeg.Filters;
using Hudl.Ffmpeg.Filters.BaseTypes;
using Hudl.Ffmpeg.Resolution.BaseTypes;
using Hudl.Ffmpeg.Resources.BaseTypes;
using Hudl.Ffmpeg.Settings;
using Hudl.Ffmpeg.Settings.BaseTypes;
using Hudl.Ffmpeg.Templates.BaseTypes;

namespace Hudl.Ffmpeg.Templates
{
    public class Resolution480P<TResource> : BaseFilterchainAndSettingsTemplate<TResource>
        where TResource : IVideo, new()
    {
        public Resolution480P()
            : base(SettingsCollectionResourceType.Output)
        {
            BaseFilterchain.Filters.AddRange(
                new Scale(ScalePresetType.Hd480),
                new SetDar(new FfmpegRatio(16, 9)),
                new SetSar(new FfmpegRatio(1, 1))
            );

            BaseSettings.AddRange(SettingsCollection.ForOutput(
                new Dimensions(ScalePresetType.Hd480),
                new AspectRatio(new FfmpegRatio(16, 9)))
            );
        }
    }
}