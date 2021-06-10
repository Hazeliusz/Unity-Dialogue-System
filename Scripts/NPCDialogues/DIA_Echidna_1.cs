using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIA_Echidna_1 : DialogueBase
{
    public override IEnumerator Interact()
    {
        ChangeSpeaker(1);
        yield return NextLineAndWait();
        ChangeSpeaker(0);
        yield return NextLineAndWait();
        ChangeSpeaker(1);
        yield return NextLineAndWait();
        ChangeSpeaker(0);
        yield return NextLineAndWait();
        yield return NextLineAndWait();
        ChangeSpeaker(1);
        yield return NextLineAndWait();
        EndDialogue();
    }
}
