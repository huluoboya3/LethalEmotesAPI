﻿using LethalCompanyInputUtils.Api;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;

namespace LethalEmotesAPI
{
    public class EmotesInputSettings : LcInputActions
    {
        public static EmotesInputSettings Instance = new();

        [InputAction("<Keyboard>/", Name = "Open Emote Wheel")]
        public InputAction EmoteWheel { get; set; }

        [InputAction("<Mouse>/left", Name = "Cycle Wheel Left")]
        public InputAction Left {  get; set; }

        [InputAction("<Mouse>/right", Name = "Cycle Wheel Right")]
        public InputAction Right { get; set; }

        [InputAction("<Keyboard>/f", Name = "Play Random Emote")]
        public InputAction RandomEmote {  get; set; }

        [InputAction("<Keyboard>/v", Name = "Join Emote")]
        public InputAction JoinEmote { get; set; }

        [InputAction("<Keyboard>/b", Name = "Bind Currently Playing Emote To Current Selection")]
        public InputAction SetCurrentEmoteToWheel { get; set; }

        [InputAction("<Keyboard>/b", Name = "Fuck you")]
        public InputAction TestButton { get; set; }
    }
}
