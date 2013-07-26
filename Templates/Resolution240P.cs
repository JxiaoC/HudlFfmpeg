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
    public class Resolution240P<TResource> : BaseFilterchainAndSettingsTemplate<TResource>
        where TResource : IVideo, new()
    {
        public Resolution240P()
            : base(SettingsCollectionResourceType.Output)
        {
            BaseFilterchain.Filters.AddRange(
                new Scale(ScalePresetType.Sd240),
                new SetDar(new FfmpegRatio(16, 9)),
                new SetSar(new FfmpegRatio(1, 1))
            );

            BaseSettings.AddRange(SettingsCollection.ForOutput(
                new Dimensions(ScalePresetType.Sd240),
                new AspectRatio(new FfmpegRatio(16, 9)))
            );
        }
    }
}
