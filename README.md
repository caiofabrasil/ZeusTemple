# ZeusTemple

- Unity 6000.0.58f2 / HDRP


- Tema escolhido : ZEUS
Ambos os temas me apeteceram muito, mas optei por zeus por ter conseguido visualizar o produto final mais rapido do que na versão do Áres, o que me ganharia tempo na parte de conceituação.

- instruções de execução :
Utilize o slider para modificar o perfil de cores dos efeitos visuals de Amarelo (0) para Azul (1) como indicado na UI
Passe o mouse por cima da Esfera de energia, e clique nela para ativar o Main Event


- Descrição dos shaders e efeitos visuais criados:

Todos os Shaders e VFX e texturas do projeto foram feitos durante o tempo do teste para uso exclusivo no projeto

Shaders: Amplify Shader Editor - Optei por esse editor de shader ao inves do ShaderGraph pois prefiro ele para execuções e prototipagens rápidas
Substance Designer: Todas as Texturas do projeto foram feitas utilizando o Substance Designer
Houdini :Todas as Custom Meshes para os VFX foram feitas utilizando o Houdini, Assim como a edição de todas as meshes e animações

Demais objetos 3D foram baixados gratuitamente da internet, ao final do Read-ME colocarei os links dos downloads

- Esfera de energia (Shader : EnergyBall)
   - Texturas criadas utilizando substance designer
   - Shader da energia utilizando layers de composição , fresnel e panning textures
- Efeitos eletricos (Shader : Thunder_Dissolve)
   - Pequenos raios de eletricidade rodeando objetos, utilizados para passar o efeito de "eletrizado" da estatua e esfera
      - Feito utilizando uma custom mesh para comportar as texturas
      - Texturas de raio usando métodos SDF para dissolve controlado por parametros do shader
      - Custom Data curves no sistema de particula para controlar o dissolve baseado no lifetime da particula individualmente
- Eletric Ray (Shader : EletricRay) 
   - VFX - Raios eletricos saindo da esfera, simulando colisão com objetos ao redor
     -  Shader de distortion aplicado em uma faixa branca comum para simular efeito de eletricidade distorcida
     -  VFXs de composição ao redor, incluindo luzes e faiscas
- Faíscas de eletricidade (Shader : particle_Additive
- EnergyFlow
  - Custom Mesh com UV preparado para o efeito de energia transitando da esfera para a estatua
  - Custom VFX textures feitas para o efeito
  - Animação de parametros para mascarar parte do efeito para dar a sensação do efeito estar crescendo
- Clouds VFX

- Scripts :
   - VFX Manager - controla a troca de cor dos VFXs utilizando ScriptableObjects com perfils de cores para trocar os VFX de forma artisticamente controlada
   - Clickable Object - Utiliza o OnMouseDown para atrelar um Unity Event para tocar a Timeline usando a esfera 

- Técnicas de otimização aplicadas:

- Todos os modelos 3D foram tratados no Houdini para diminuir o polycount e resolver problemas de normais
- Project settings foi editado para deixar o HDRP mais otimizado possivel, deixando apenas as funções necessarias para a scene, Para isso foi necessario criar algumas builds, usar o DeepProfile nas builds criadas para verificar em tempo de execução, gargalos de CPU e GPU, e fazer otimizações necessarias. Assim como o Frame Debbuger para checar Batches e pipeline de renders
- Texturas criadas no SD foram packed em diferentes channels para otimizar utilização de texturas 


Houdini Project:
<img width="3416" height="1332" alt="image" src="https://github.com/user-attachments/assets/bbd03286-dd26-498c-91d3-1175cc8bccfd" />

Substance Designer Project:
<img width="1095" height="777" alt="image" src="https://github.com/user-attachments/assets/7e96f6e9-02bb-449d-b64c-1a869bb16578" />

SHADERS:

EletricRay
<img width="1427" height="827" alt="image" src="https://github.com/user-attachments/assets/61a288ce-22d1-4753-9cdf-79348b81668b" />

Thunder_Dissolve
<img width="1429" height="827" alt="image" src="https://github.com/user-attachments/assets/21f9b6fd-abd6-403e-b0e1-f54c809aab1b" />

EletricBall
<img width="1432" height="822" alt="image" src="https://github.com/user-attachments/assets/18a3508c-7beb-4d19-bb15-de52dd92871f" />

EnergyFlow
<img width="1432" height="826" alt="image" src="https://github.com/user-attachments/assets/41be815c-3e34-4aaa-8d82-22895ba6d70b" />

Particle_Additive
<img width="1428" height="823" alt="image" src="https://github.com/user-attachments/assets/2b81f029-823e-48f3-9800-3269555c9605" />


