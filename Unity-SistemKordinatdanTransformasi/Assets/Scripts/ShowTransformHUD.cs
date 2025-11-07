using UnityEngine;
using TMPro;

public class ShowTransformHUD : MonoBehaviour
{
    public TextMeshProUGUI hud;
    private MoveInSpace mover;

    void Start()
    {
        mover = GetComponent<MoveInSpace>();   // biar HUD baca mode dari movement
    }

    void Update()
    {
        if (!hud) return;

        Vector3 world = transform.position;
        Vector3 local = transform.localPosition;
        string mode = (mover != null && mover.useLocal) ? "Local (Space.Self)" : "World (Space.World)";

        hud.text =
            "World: " + world.ToString("F2") + "\n" +
            "Local: " + local.ToString("F2") + "\n" +
            "Mode: " + mode;
    }
}
