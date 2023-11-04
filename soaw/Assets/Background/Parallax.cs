using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float _comprimento;
    private float _posInicial;

    private Transform cam;

    public float ParallaxEffect;
    void Start()
    {
        _posInicial = transform.position.x;
        _comprimento = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform;

    }

    // Update is called once per frame
    void Update()
    {
        ParallaxEfeito();

    }

    public void ParallaxEfeito()
    {
        float RePosi = cam.transform.position.x * (1 - ParallaxEffect); // para fazer o fundo reposicionar.
        float distancia = cam.transform.position.x * ParallaxEffect; // para que a camera siga no eixo x e tenha o efeito

        transform.position = new Vector3(_posInicial + distancia, transform.position.y, transform.position.z);

        if (RePosi > _posInicial + _comprimento)
        {
            _posInicial += _comprimento;
        }
        else if (RePosi < _posInicial - _comprimento)
        {
            _posInicial -= _comprimento;
        }
    }

}

