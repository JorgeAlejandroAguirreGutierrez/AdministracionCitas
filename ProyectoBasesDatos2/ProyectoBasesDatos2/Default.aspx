<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoBasesDatos2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>Pagina Principal EPS SERVICO</title>

    <!-- Bootstrap core CSS -->
    <link href="vistas/css/bootstrap.min.css" rel="stylesheet" />

    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <link href="vistas/css/ie10-viewport-bug-workaround.css" rel="stylesheet" />

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="vistas/js/ie-emulation-modes-warning.js"></script>
    <style type="text/css"></style>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

    <!-- Custom styles for this template -->
    <link href="vistas/css/carousel.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="navbar-wrapper">
                <div class="container">
                    <nav class="navbar navbar-inverse navbar-static-top">
                        <div class="container">
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                                    <span class="sr-only">Toggle navigation</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <a class="navbar-brand" href="https://getbootstrap.com/examples/carousel/#">Project name</a>
                            </div>
                            <div id="navbar" class="navbar-collapse collapse">
                                <ul class="nav navbar-nav">
                                    <li class="active"><a href="#">Home</a></li>
                                    <li><a href="#">Mision</a></li>
                                    <li><a href="#">Vision</a></li>
                                    <li><a href="#">Contacto</a></li>
                                </ul>
                                <div id="navbar2" class="navbar-collapse collapse">
                                    <div class="navbar-form navbar-right">
                                        <div class="form-group">
                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-success" OnClick="Button1_Click" />
                                    </div>
                                </div>
                                <!--/.navbar-collapse -->
                            </div>

                        </div>
                    </nav>
                </div>
            </div>
            <!-- Carousel
    ================================================== -->
            <div id="myCarousel" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1" class=""></li>
                    <li data-target="#myCarousel" data-slide-to="2" class=""></li>
                </ol>
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <img class="first-slide" src="vistas/images/imagen1.jpg" alt="First slide" />
                        <div class="container">
                            <div class="carousel-caption">
                                <h1>EPS SERVICO.</h1>
                                <p>EPS SERVICO La Empresa que invierte en la salud de los COLOMBIANOS.</p>
                                <%--<p><a class="btn btn-lg btn-primary" href="https://getbootstrap.com/examples/carousel/#" role="button">Sign up today</a></p>--%>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <img class="second-slide" src="vistas/images/imagen2.jpg" alt="Second slide" />
                        <div class="container">
                            <div class="carousel-caption">
                                <h1>LAS MEJORES INSTITUCIONES DE SALUD</h1>
                                <p>Actualmente EPS SERVICO tiene mas de 500 contratos con las mejores instituciones de IPS  de COLOMBIA</p>
                                <%--<p><a class="btn btn-lg btn-primary" href="https://getbootstrap.com/examples/carousel/#" role="button">Learn more</a></p>--%>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <img class="third-slide" src="vistas/images/imagen3.jpg" alt="Third slide" />
                        <div class="container">
                            <div class="carousel-caption">
                                <h1>LOS MEJORES PROFESIONALES A SUS SERVICIOS</h1>
                                <p>Cubrimos todas las especialidades del area de salud para que no haya limitaciones en la prestación de los servicios.</p>
                                <%--<p><a class="btn btn-lg btn-primary" href="https://getbootstrap.com/examples/carousel/#" role="button">Browse gallery</a></p>--%>
                            </div>
                        </div>
                    </div>
                </div>
                <a class="left carousel-control" href="https://getbootstrap.com/examples/carousel/#myCarousel" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control" href="https://getbootstrap.com/examples/carousel/#myCarousel" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
            <!-- /.carousel -->


            <!-- Marketing messaging and featurettes
    ================================================== -->
            <!-- Wrap the rest of the page in another container to center all the content. -->

            <div class="container marketing">

                <!-- Three columns of text below the carousel -->
                <div class="row">
                    <div class="col-lg-4">
                        <h2>Condecoracion a la clinica servico.</h2>
                        <p>Por la mejor prestacion del servicio, y por sus grandes logros
                            en investigacion servico clinica a sido  condecorada en el año 2015 como la 
                            mejor  nivel nacional, el presidente de la nacion hizo
                            entrega de una placa  que ratifica la labor. 
                            con pasion y decoro por la labor servico la mejor opcion </p>
                        <p><a class="btn btn-default" href="https://www.google.com.co" role="button">Ver detalles »</a></p>
                    </div>
                    <!-- /.col-lg-4 -->
                    <div class="col-lg-4">
                        <h2>Salvando vidas dando felicidad</h2>
                        <p>EL pasado 15 de noviembre ingreso a nuestra sala de urgencias
                            gilberto posada, cantante de opera que llego con un preinfarto
                            se le presto la atencion pertinente y se logro estabilizar y dar un tratamiento efectivo
                            el cantante dara un concierto gratuito para la comunidad en honor a la labor de
                            nuestros medicos servico.</p>
                        <p><a class="btn btn-default" href="https://www.google.com.co" role="button">Ver detalles »</a></p>
                    </div>
                    <!-- /.col-lg-4 -->
                    <div class="col-lg-4">
                        
                        <h2>Sentido social servico </h2>
                        <p>llega diciembre y servico ya empezo la recolecta de regalos que son
                            sonrisas para los niños internos de nuestras clinicas asociadas, esta labor la 
                            haran cada uno de nuestros colaboradores en sedes principales de servico, 
                            si quieres apoyar se recibiran juguetes y ropa para niños de cuna hasta los
                             13 años</p>
                        <p><a class="btn btn-default" href="https://www.google.com.co" role="button">Ver detalles »</a></p>
                    </div>
                    <!-- /.col-lg-4 -->
                </div>
                <!-- /.row -->


                <!-- START THE FEATURETTES -->

                <hr class="featurette-divider" />

                <div class="row featurette">
                    <div class="col-md-7">
                        <h2 class="featurette-heading"><span class="text-muted">Hospital en Pasto entre los mejores de América Latina.</span></h2>
                        <p class="lead">La publicación de negocios, economías y finanzas de Latinoamérica, reconoció su eficiencia en la atención médica y los altos niveles en el manejo de los recursos económicos y una eficaz dotación tecnológica.</p>
                    </div>
                    <div class="col-md-5">
                        <img class="featurette-image img-responsive center-block" alt="500x500" src="vistas/images/imagen4.jpg" data-holder-rendered="true" />
                    </div>
                </div>

                <hr class="featurette-divider" />

                <div class="row featurette">
                    <div class="col-md-7 col-md-push-5">
                        <h2 class="featurette-heading"><span class="text-muted">Dos caleños entre los mejores médicos internos del país</span></h2>
                        <p class="lead">Luego de presentar una prueba de 100 preguntas, entre 544 médicos internos de todo el país, los caleños Carlos Enrique Endo Abella de la Universidad Javeriana e Iván Posso de la Universidad Icesi ocuparon el primer y segundo lugar como los mejores internos del año.</p>
                    </div>
                    <div class="col-md-5 col-md-pull-7">
                        <img class="featurette-image img-responsive center-block" alt="500x500" src="vistas/images/imagen5.jpg" data-holder-rendered="true" />
                    </div>
                </div>

                <hr class="featurette-divider" />

                <div class="row featurette">
                    <div class="col-md-7">
                        <h2 class="featurette-heading"><span class="text-muted">Solicite citas médicas a través de internet.</span></h2>
                        <p class="lead">El rápido avance de la tecnología está logrando abrir nuevos caminos que permiten mejorar y facilitar la vida de las personas. Por ejemplo, hoy en día en la web es posible interactuar con distintos portales que brindan entretenimiento, educan y hasta permiten comprar solo con un clic.</p>
                    </div>
                    <div class="col-md-5">
                        <img class="featurette-image img-responsive center-block" alt="500x500" src="vistas/images/imagen6.jpg" data-holder-rendered="true" />
                    </div>
                </div>

                <hr class="featurette-divider" />

                <!-- /END THE FEATURETTES -->


                <!-- FOOTER -->
                <footer>
                    <p class="pull-right"><a href="https://getbootstrap.com/examples/carousel/#">Volver arriba</a></p>
                    <p>© 2015<a href="https://getbootstrap.com/examples/carousel/#">Privacy</a> · <a href="https://getbootstrap.com/examples/carousel/#">Terminos</a></p>
                </footer>

            </div>
            <!-- /.container -->


            <!-- Bootstrap core JavaScript
    ================================================== -->
            <!-- Placed at the end of the document so the pages load faster -->
            <script src="vistas/js/jquery.min.js"></script>
            <script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')</script>
            <script src="vistas/js/bootstrap.min.js"></script>
            <!-- Just to make our placeholder images work. Don't actually copy the next line! -->
            <script src="vistas/js/holder.min.js"></script>
            <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
            <script src="vistas/js/ie10-viewport-bug-workaround.js"></script>


            <svg xmlns="http://www.w3.org/2000/svg" width="500" height="500" viewBox="0 0 500 500" preserveAspectRatio="none" style="display: none; visibility: hidden; position: absolute; top: -100%; left: -100%;">
                <defs>
                    <style type="text/css"></style>
                </defs><text x="0" y="25" style="font-weight: bold; font-size: 25pt; font-family: Arial, Helvetica, Open Sans, sans-serif">500x500</text>
            </svg>
        </div>
    </form>
</body>
</html>
