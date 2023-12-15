using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottlePowerUp : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (id == 1)
            {
                GameManager.instance.bottleHeal++;
            }
            else if (id == 2)
            {
                GameManager.instance.bottleSpeed++;
            }
            else if (id == 3)
            {
                GameManager.instance.bottleAtk++;
            }
            AudioManager.instance.PlaySfx("coin");
            UiPresent.Instance.UpdateUiPresent();
            gameObject.SetActive(false);
        }
    }
}
