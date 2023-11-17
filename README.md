# mofa-nft-rendering-in-urp
This is the rendering project for the MOFA project, primarily responsible for creating and outputting the visual content of MOFA NFTs. In this project, there are visuals for three early versions of NFTs and one created during the 2023 Flow Hackathon. They are located in the scenes 'NFT Version 1' and 'NFT Version 2_Flow.'

## Demos

### Mofa-Mystic
https://github.com/holoi/mofa-nft-rendering-in-urp/assets/52849063/4360e9ac-3cf2-4c07-b9ab-634288752a45


### Mofa-Thunder
https://github.com/holoi/mofa-nft-rendering-in-urp/assets/52849063/ee1d7455-59b6-41af-8fdd-92ec97c1afc8


### Mofa-Nature
https://github.com/holoi/mofa-nft-rendering-in-urp/assets/52849063/b4e247ce-956e-410e-84ad-bc66f9612c26

## System requirements

Unity: 2023.3.12f1 and above.

## How to try it

For Version0.1, all nfts are composed of object "Weapon" and object "Field".

<img width="306" alt="image" src="https://github.com/holoi/mofa-nft-rendering-in-urp/assets/52849063/1ef5aeda-26ed-4173-82db-838f9cb0bfa2">

"Weapon" is the shaple in center, and "Field" is the particle field around it.

### “Weapon”

"Field" is maily influenced by the vfx asset attached:

<img width="314" alt="image" src="https://github.com/holoi/mofa-nft-rendering-in-urp/assets/52849063/12535d77-ec88-432f-b9f5-5cf582253e73">

Among all the properties, "SDF Texture" controls the shape of "Weapon".

### "Field"

"Field" is maily influenced by the vfx asset attached:

<img width="315" alt="image" src="https://github.com/holoi/mofa-nft-rendering-in-urp/assets/52849063/1ab3540f-2482-4534-be28-c4f5e57e495e">

Among all the properties, "SDF" and "SDF(A)" control the shape of "Field"。

## Create you own visuals

Using Unity SDF Bake Tool is the fastest way to create your own sdf textures for "Weapon":

1. Create or download a 3d model
2. Import to Unity.
3. Open SDF Bake Tool, drag the mesh to it and bake.
For more information about how to use SDF Bake Tool: https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@15.0/manual/sdf-bake-tool.html#:~:text=The%20SDF%20Bake%20Tool%20is,use%20in%20a%20visual%20effect.


Using external tools to vreate your sdf textures for "Field"

1. There are some sdf textures under: "NFT"->"Weapons Resources"->"SDFTextures", you can drag them into "Field" objedct to try it out. 
2. If you got your own sdf textures, import to Unity and drag to "Field".
3. Recommended Tools：
  vectoraygen: https://jangafx.com/software/vectoraygen/

## Reference

1. https://github.com/keijiro/SdfVfxSamples
2. https://github.com/keijiro/SushiVfx
