## API_PolloFeliz 
Autores
Eddy José Calero Perez 				             2020-3003S
Haxell Antonio Trejos Rodriguez		         2011-39659
Cairo Manuel Rocha Machado 			           2019-0033J
Leonidas Otoniel Aguirre Munguia  		     2020-0260I

API_PolloFeliz sera el backend de Nuestro SGI_PolloFeliz, encargado de gestionar la lógica del negocio, los datos de productos, usuarios y reportes de ventas.
Su propósito es ofrecer un servicio estable y seguro para nuestro SGI.

## Tecnologias
.Net 8.0
ORM = EntityFrameworkCore y Dapper
BD = PostgreSQL en Neon Console nos proporciona 500Mb Gratuitos

## Capa Core (Núcleo)

Es el centro lógico del sistema.

Define las interfaces que describen cómo deben comportarse los servicios y repositorios.

No depende de ninguna otra capa; las demás capas dependen de ella.

## Capa Models

Representa la estructura de los datos que maneja la aplicación.

Define las entidades o modelos que reflejan la información del dominio (por ejemplo, usuarios, etc.).

Estas clases son usadas en la comunicación entre las capas y sirven como base para el almacenamiento en la base de datos.

## Capa Repository

Se encarga de la interacción con la base de datos.

Implementa las interfaces definidas en el núcleo (Core) para realizar operaciones CRUD.

Aísla la lógica de acceso a datos del resto del sistema.

## Capa Services

Contiene la lógica de negocio de la aplicación.

Aplica, validaciones y flujos de trabajo.

No accede directamente a la base de datos; lo hace a través de los repositorios.

## Capa Commons

Reúne los recursos compartidos por todo el sistema.

Evita la duplicación de código y promueve la reutilización.

## Flujo entre las capas

El cliente envía una solicitud a la API.

El controlador (API) la recibe y la envía al servicio correspondiente.

El servicio aplica la lógica de negocio y solicita o almacena información mediante el repositorio.

El repositorio interactúa con la base de datos y devuelve los resultados al servicio.

El servicio devuelve una respuesta procesada al controlador, que finalmente la entrega al cliente.

