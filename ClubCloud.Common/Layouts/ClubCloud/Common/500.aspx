<%@ Page language="C#" MasterPageFile="~/_layouts/15/errorv15.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" meta:webpartpageexpansion="full"  %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <style type="text/css">
        body {
            background-color: #0072C6 !important;
            margin: 0px !important;
            overflow: hidden !important;
            font-family: Monospace !important;
            font-size: 13px !important;
            text-align: center !important;
            font-weight: bold !important;
            text-align: center !important;
            width: 100% !important;
        }

        a {
            color: #0078ff;
        }

        #login {
            position: absolute;
            width: 300px;
            height: 200px;
            z-index: 15;
            top: 50%;
            left: 50%;
            margin: -100px 0 0 -150px;
            background: red;
            border-radius: 1px;
            border-color: #0072C6;
            transition: all 300ms;
        }

        #ms-error-header {
            margin: 0px !important;
            min-height: 0px !important;
        }

        input[type="text"].focus-5, input:focus, input[type="text"]:focus {
            outline: 0 none;
            box-shadow: 0 0 0 5px #0072C6;
        }

        input[type="text"], input[type="password"] {
            width: 100%;
            height: 40px;
            border-color: #0072C6;
            text-indent: 5px;
            border-radius: 3px;
            margin: 5px;
            transition: all 300ms;
        }

        input[type="submit"] {
            font-size: 24px;
            color: #fff;
            width: 100%;
            margin: 10px;
            border: none;
            background-color: #0072C6;
            border-radius: 3px;
        }

    </style>

</asp:Content>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    <sharepoint:projectproperty property="Title" runat="server"/>
</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
	<div id="login">
		<div style="width: 400px; padding: 50px 35px; background: hsl(0, 0%, 100%); color: #0072C6; color: #0072C6; line-height: 18px !important; font: 500 12px/18px 'Futura', Arial, sans-serif; letter-spacing: 1px; text-align: center;" id="rome-error">
			<h1 id="pageTitle" class="lined">Donder Wolken</h1>
			<p class="description">Er is iets mis gegaan met uw aanvraag.</p>
			401
			<SharePoint:ReturnLink Text="<%$Resources:wss,multipages_back_to_site%>" Id="idSimpleGoBackToHome" runat="server"/>
		</div>
	</div>
	<WebPartPages:AllowFraming runat="server" />
	<script src="scripts/three.min.js" type="text/javascript"></script>
	<script src="scripts/Detector.js" type="text/javascript"></script>


    <script id="vs" type="x-shader/x-vertex">

			varying vec2 vUv;

			void main() {

				vUv = uv;
				gl_Position = projectionMatrix * modelViewMatrix * vec4( position, 1.0 );

			}

    </script>

    <script id="fs" type="x-shader/x-fragment">

			uniform sampler2D map;

			uniform vec3 fogColor;
			uniform float fogNear;
			uniform float fogFar;

			varying vec2 vUv;

			void main() {

				float depth = gl_FragCoord.z / gl_FragCoord.w;
				float fogFactor = smoothstep( fogNear, fogFar, depth );

				gl_FragColor = texture2D( map, vUv );
				gl_FragColor.w *= pow( gl_FragCoord.z, 20.0 );
				gl_FragColor = mix( gl_FragColor, vec4( fogColor, gl_FragColor.w ), fogFactor );

			}

    </script>

    <script type="text/javascript">

        //if (!Detector.webgl) Detector.addGetWebGLMessage();

             var container;
             var camera, scene, renderer;
             var mesh, geometry, material;

             var mouseX = 0, mouseY = 0;
             var start_time = Date.now();

             var windowHalfX = window.innerWidth / 2;
             var windowHalfY = window.innerHeight / 2;

             init();

             function init() {

                 container = document.createElement('div');
                 document.body.appendChild(container);

                 // Bg gradient

                 var canvas = document.createElement('canvas');
                 canvas.width = 32;
                 canvas.height = window.innerHeight;

                 var context = canvas.getContext('2d');

                 var gradient = context.createLinearGradient(0, 0, 0, canvas.height);
                 gradient.addColorStop(0, "#1e4877");
                 gradient.addColorStop(0.5, "#4584b4");

                 context.fillStyle = gradient;
                 context.fillRect(0, 0, canvas.width, canvas.height);

                 container.style.background = 'url(' + canvas.toDataURL('image/png') + ')';
                 container.style.backgroundSize = '32px 100%';

                 //

                 camera = new THREE.PerspectiveCamera(30, window.innerWidth / window.innerHeight, 1, 3000);
                 camera.position.z = 6000;

                 scene = new THREE.Scene();

                 geometry = new THREE.Geometry();

                 var texture = THREE.ImageUtils.loadTexture('images/cloud10.png', null, animate);
                 texture.magFilter = THREE.LinearMipMapLinearFilter;
                 texture.minFilter = THREE.LinearMipMapLinearFilter;

                 var fog = new THREE.Fog(0x4584b4, -100, 3000);

                 material = new THREE.ShaderMaterial({

                     uniforms: {

                         "map": { type: "t", value: texture },
                         "fogColor": { type: "c", value: fog.color },
                         "fogNear": { type: "f", value: fog.near },
                         "fogFar": { type: "f", value: fog.far },

                     },
                     vertexShader: document.getElementById('vs').textContent,
                     fragmentShader: document.getElementById('fs').textContent,
                     depthWrite: false,
                     depthTest: false,
                     transparent: true

                 });

                 var plane = new THREE.Mesh(new THREE.PlaneGeometry(64, 64));

                 for (var i = 0; i < 8000; i++) {

                     plane.position.x = Math.random() * 1000 - 500;
                     plane.position.y = -Math.random() * Math.random() * 200 - 15;
                     plane.position.z = i;
                     plane.rotation.z = Math.random() * Math.PI;
                     plane.scale.x = plane.scale.y = Math.random() * Math.random() * 1.5 + 0.5;

                     THREE.GeometryUtils.merge(geometry, plane);

                 }

                 mesh = new THREE.Mesh(geometry, material);
                 scene.add(mesh);

                 mesh = new THREE.Mesh(geometry, material);
                 mesh.position.z = -8000;
                 scene.add(mesh);

                 renderer = new THREE.WebGLRenderer({ antialias: false });
                 renderer.setSize(window.innerWidth, window.innerHeight);
                 container.appendChild(renderer.domElement);

                 document.addEventListener('mousemove', onDocumentMouseMove, false);
                 window.addEventListener('resize', onWindowResize, false);

             }

             function onDocumentMouseMove(event) {

                 mouseX = (event.clientX - windowHalfX) * 0.25;
                 mouseY = (event.clientY - windowHalfY) * 0.15;

             }

             function onWindowResize(event) {

                 camera.aspect = window.innerWidth / window.innerHeight;
                 camera.updateProjectionMatrix();

                 renderer.setSize(window.innerWidth, window.innerHeight);

             }

             function animate() {

                 requestAnimationFrame(animate);

                 position = ((Date.now() - start_time) * 0.05) % 8000;

                 camera.position.x += (mouseX - camera.position.x) * 0.01;
                 camera.position.y += (-mouseY - camera.position.y) * 0.01;
                 camera.position.z = -position + 8000;

                 renderer.render(scene, camera);

             }

             </script>
</asp:Content>