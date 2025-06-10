using UnityEngine;

public class Inventario : MonoBehaviour
{   
    public enum Estados
    {
        Vazio,
        ComEspada
    }

    [Header("Inventario")]
    [SerializeField] 
    public Estados item;


    void Start()
    {
        item = Estados.Vazio;
    }

    public void DropItems()
    {
        item = Estados.Vazio;
    }

    public void AdicionaEspada()
    {
        item = Estados.ComEspada;
    }
}
