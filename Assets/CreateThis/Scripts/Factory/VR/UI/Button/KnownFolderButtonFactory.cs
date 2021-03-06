﻿using UnityEngine;
using CreateThis.Unity;
using CreateThis.System;
using CreateThis.VR.UI.File;
using CreateThis.VR.UI.Button;

namespace CreateThis.Factory.VR.UI.Button {
    public class KnownFolderButtonFactory : MomentaryButtonFactory {
        public FileBase filePanel;
        public KnownFolder knownFolder;

        public void PopulateButton(KnownFolderButton button, AudioSource audioSourceDown, AudioSource audioSourceUp) {
            base.PopulateButton(button, audioSourceDown, audioSourceUp);
            button.knownFolder = knownFolder;
            button.filePanel = filePanel;
        }

        protected override void AddButton(GameObject target, AudioSource audioSourceDown, AudioSource audioSourceUp) {
            KnownFolderButton button = Undoable.AddComponent<KnownFolderButton>(target);
            PopulateButton(button, audioSourceDown, audioSourceUp);
        }
    }
}