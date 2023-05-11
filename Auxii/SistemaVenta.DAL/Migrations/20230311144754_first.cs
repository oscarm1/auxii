using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVenta.DAL.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__8A3D240C512DD09F", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Configuracion",
                columns: table => new
                {
                    recurso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    propiedad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    valor = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    idMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    idMenuPadre = table.Column<int>(type: "int", nullable: true),
                    icono = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    controlador = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    paginaAccion = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Menu__C26AF483A6068BB7", x => x.idMenu);
                    table.ForeignKey(
                        name: "FK__Menu__idMenuPadr__24927208",
                        column: x => x.idMenuPadre,
                        principalTable: "Menu",
                        principalColumn: "idMenu");
                });

            migrationBuilder.CreateTable(
                name: "Negocio",
                columns: table => new
                {
                    idNegocio = table.Column<int>(type: "int", nullable: false),
                    urlLogo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nombreLogo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    numeroDocumento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    porcentajeImpuesto = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    simboloMoneda = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Negocio__70E1E1076DE9A588", x => x.idNegocio);
                });

            migrationBuilder.CreateTable(
                name: "NumeroCorrelativo",
                columns: table => new
                {
                    idNumeroCorrelativo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ultimoNumero = table.Column<int>(type: "int", nullable: true),
                    cantidadDigitos = table.Column<int>(type: "int", nullable: true),
                    gestion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NumeroCo__25FB547E65A40777", x => x.idNumeroCorrelativo);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    idProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Proveedor__645723A6ACC301A0", x => x.idProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rol__3C872F7648303C61", x => x.idRol);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoMovimiento",
                columns: table => new
                {
                    idTipoDocumentoMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Naturaleza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TipoDocu__A9D59AEE8BEB6B2E", x => x.idTipoDocumentoMovimiento);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoBarra = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    marca = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    idCategoria = table.Column<int>(type: "int", nullable: true),
                    idProveedor = table.Column<int>(type: "int", nullable: true),
                    stock = table.Column<int>(type: "int", nullable: true),
                    urlImagen = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nombreImagen = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PrecioCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Imp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    precio = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__07F4A132797CBE6F", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK__Producto__idCate__36B12243",
                        column: x => x.idCategoria,
                        principalTable: "Categoria",
                        principalColumn: "idCategoria");
                    table.ForeignKey(
                        name: "FK__Producto__idProv__36B12244",
                        column: x => x.idProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "idProveedor");
                });

            migrationBuilder.CreateTable(
                name: "RolMenu",
                columns: table => new
                {
                    idRolMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idRol = table.Column<int>(type: "int", nullable: true),
                    idMenu = table.Column<int>(type: "int", nullable: true),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RolMenu__CD2045D88E5957FC", x => x.idRolMenu);
                    table.ForeignKey(
                        name: "FK__RolMenu__idMenu__2C3393D0",
                        column: x => x.idMenu,
                        principalTable: "Menu",
                        principalColumn: "idMenu");
                    table.ForeignKey(
                        name: "FK__RolMenu__idRol__2B3F6F97",
                        column: x => x.idRol,
                        principalTable: "Rol",
                        principalColumn: "idRol");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idRol = table.Column<int>(type: "int", nullable: true),
                    urlFoto = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nombreFoto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    clave = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    esActivo = table.Column<bool>(type: "bit", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuario__645723A6ACC301A0", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK__Usuario__idRol__300424B4",
                        column: x => x.idRol,
                        principalTable: "Rol",
                        principalColumn: "idRol");
                });

            migrationBuilder.CreateTable(
                name: "Movimiento",
                columns: table => new
                {
                    idMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroMovimiento = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    idTipoDocumentoMovimiento = table.Column<int>(type: "int", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    IdProveedor = table.Column<int>(type: "int", nullable: true),
                    NumeroDocumentoExterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentoCliente = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    nombreCliente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    subTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    impuestoTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Movimiento__077D56148B22AC5G", x => x.idMovimiento);
                    table.ForeignKey(
                        name: "FK__Movimiento__idProveedor__403A8C7D",
                        column: x => x.IdProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "idProveedor");
                    table.ForeignKey(
                        name: "FK__Movimiento__idTipoDoc__3F466844",
                        column: x => x.idTipoDocumentoMovimiento,
                        principalTable: "TipoDocumentoMovimiento",
                        principalColumn: "idTipoDocumentoMovimiento");
                    table.ForeignKey(
                        name: "FK__Movimiento__idUsuario__403A8C7D",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "DetalleMovimiento",
                columns: table => new
                {
                    idDetalleMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMovimiento = table.Column<int>(type: "int", nullable: true),
                    idProducto = table.Column<int>(type: "int", nullable: false),
                    descripcionProducto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: true),
                    precio = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DetalleV__BFE2843FB3D3EFB5", x => x.idDetalleMovimiento);
                    table.ForeignKey(
                        name: "FK_DetalleMovimiento_Producto",
                        column: x => x.idProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__DetalleVe__idVen__440B1D61",
                        column: x => x.idMovimiento,
                        principalTable: "Movimiento",
                        principalColumn: "idMovimiento");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMovimiento_idMovimiento",
                table: "DetalleMovimiento",
                column: "idMovimiento");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMovimiento_idProducto",
                table: "DetalleMovimiento",
                column: "idProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_idMenuPadre",
                table: "Menu",
                column: "idMenuPadre");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_IdProveedor",
                table: "Movimiento",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_idTipoDocumentoMovimiento",
                table: "Movimiento",
                column: "idTipoDocumentoMovimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_idUsuario",
                table: "Movimiento",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_idCategoria",
                table: "Producto",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_idProveedor",
                table: "Producto",
                column: "idProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_RolMenu_idMenu",
                table: "RolMenu",
                column: "idMenu");

            migrationBuilder.CreateIndex(
                name: "IX_RolMenu_idRol",
                table: "RolMenu",
                column: "idRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_idRol",
                table: "Usuario",
                column: "idRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracion");

            migrationBuilder.DropTable(
                name: "DetalleMovimiento");

            migrationBuilder.DropTable(
                name: "Negocio");

            migrationBuilder.DropTable(
                name: "NumeroCorrelativo");

            migrationBuilder.DropTable(
                name: "RolMenu");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Movimiento");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "TipoDocumentoMovimiento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
