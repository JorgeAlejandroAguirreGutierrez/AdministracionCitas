--DROP TABLE ATENCION;
--DROP TABLE CATEGORIA;
--DROP TABLE CURSO;
--DROP TABLE ESPECIALIDAD;
--DROP TABLE NOTICIA;
--DROP TABLE ROLESUSUARIO;
-- -----------------------------------------------------
-- Table roles
-- -----------------------------------------------------
CREATE TABLE roles (
  idroles INTEGER NOT NULL,
  tipo VARCHAR2(45) NULL,
  PRIMARY KEY (idroles));


-- -----------------------------------------------------
-- Table categoria
-- -----------------------------------------------------
CREATE TABLE categoria (
  idcategoria INTEGER NOT NULL,
  tipo VARCHAR2(45) NULL,
  PRIMARY KEY (idcategoria));


-- -----------------------------------------------------
-- Table usuario
-- -----------------------------------------------------
CREATE TABLE usuario(
  idusuario INTEGER NOT NULL,
  roles_idroles INTEGER NOT NULL,
  categoria_idcategoria INTEGER NOT NULL,
  nombre VARCHAR2(45) NULL,
  rutaimagen VARCHAR2(200) NULL,
  imagen BLOB NULL,
  cedula VARCHAR2(45) NULL,
  contrasena VARCHAR2(45) NULL,
  correo VARCHAR2(200) NULL,
  activo VARCHAR2(45),
  incumplimiento INTEGER NULL,
  PRIMARY KEY (idusuario),
  --INDEX fk_usuario_roles1_idx (roles_idroles ASC),
  --INDEX fk_usuario_categoria1_idx (categoria_idcategoria ASC),
  CONSTRAINT fk_usuario_roles FOREIGN KEY (roles_idroles) REFERENCES roles (idroles),
  CONSTRAINT fk_usuario_categoria1 FOREIGN KEY (categoria_idcategoria) REFERENCES categoria (idcategoria));
  
-- -----------------------------------------------------
-- Table noticia
-- -----------------------------------------------------
DROP TABLE NOTICIA;
CREATE TABLE  noticia (
  idnoticia INTEGER NOT NULL,
  titulo VARCHAR2(200) NULL,
  descripcion VARCHAR2(500) NULL,
  fecha DATE NULL,
  ubicacion VARCHAR2(45),
  PRIMARY KEY (idnoticia));


-- -----------------------------------------------------
-- Table curso
-- -----------------------------------------------------
CREATE TABLE curso (
  idcurso INTEGER NOT NULL,
  titulo VARCHAR2(45) NULL,
  descripcion VARCHAR2(200) NULL,
  duracion INTEGER NULL,
  fechainicio DATE NULL,
  fechafin DATE NULL,
  PRIMARY KEY (idcurso));


-- -----------------------------------------------------
-- Table programacion
-- -----------------------------------------------------
CREATE TABLE programacion (
  idprogramacion INTEGER NOT NULL,
  curso_idcurso INTEGER NOT NULL,
  actividad VARCHAR2(200) NULL,
  ubicacion VARCHAR2(45),
  PRIMARY KEY (idprogramacion, curso_idcurso),
  --INDEX fk_programacion_curso1_idx (curso_idcurso ASC),
  CONSTRAINT fk_programacion_curso1 FOREIGN KEY (curso_idcurso) REFERENCES curso (idcurso));


-- -----------------------------------------------------
-- Table especialidad
-- -----------------------------------------------------
CREATE TABLE especialidad (
  idespecialidad INTEGER NOT NULL,
  tipo VARCHAR2(45) NULL,
  PRIMARY KEY (idespecialidad));


-- -----------------------------------------------------
-- Table medico
-- -----------------------------------------------------
CREATE TABLE medico (
  idmedico INTEGER NOT NULL,
  especialidad_idespecialidad INTEGER NOT NULL,
  usuario_idusuario INTEGER NOT NULL,
  registro VARCHAR2(45) NULL,
  PRIMARY KEY (idmedico),
  --INDEX fk_medico_especialidad1_idx (especialidad_idespecialidad ASC),
  CONSTRAINT fk_medico_especialidad1 FOREIGN KEY (especialidad_idespecialidad) REFERENCES especialidad (idespecialidad),
  CONSTRAINT fk_medico_usuario1 FOREIGN KEY (usuario_idusuario) REFERENCES usuario(idusuario));

DROP TABLE MEDICO;
-- -----------------------------------------------------
-- Table atencion
-- -----------------------------------------------------
CREATE TABLE atencion (
  idatencion INTEGER NOT NULL,
  tipo VARCHAR2(45) NULL,
  PRIMARY KEY (idatencion));


-- -----------------------------------------------------
-- Table cita
-- -----------------------------------------------------
CREATE TABLE cita (
  idcita INTEGER NOT NULL,
  atencion_idatencion INTEGER NOT NULL,
  medico_idmedico INTEGER NOT NULL,
  usuario_idusuario INTEGER NOT NULL,
  agenda_idagenda INTEGER NOT NULL,
  estado VARCHAR2(45) NULL,
  PRIMARY KEY (idcita),
  --INDEX fk_cita_atencion1_idx (atencion_idatencion ASC),
  --INDEX fk_cita_medico1_idx (medico_idmedico ASC),
  --INDEX fk_cita_usuario1_idx (usuario_idusuario ASC),
  CONSTRAINT fk_cita_atencion1 FOREIGN KEY (atencion_idatencion) REFERENCES atencion (idatencion),
  CONSTRAINT fk_cita_agenda1 FOREIGN KEY (agenda_idagenda) REFERENCES agenda (idagenda),
  CONSTRAINT fk_cita_usuario1 FOREIGN KEY (usuario_idusuario) REFERENCES usuario (idusuario));

DROP TABLE CITA;
-- -----------------------------------------------------
-- Table agenda
-- -----------------------------------------------------
CREATE TABLE agenda (
  idagenda INTEGER NOT NULL,
  medico_idmedico INTEGER NOT NULL,
  fecha DATE NULL,
  hora INTEGER NULL,
  disponible VARCHAR2(45) NULL,
  PRIMARY KEY (idagenda),
  --INDEX `fk_horario_medico1_idx` (`medico_idmedico` ASC),
  CONSTRAINT fk_agenda_medico1 FOREIGN KEY (medico_idmedico) REFERENCES medico (idmedico));

DROP TABLE AGENDA;

-- -----------------------------------------------------
-- Table multa
-- -----------------------------------------------------
CREATE TABLE multa (
  idmulta INTEGER NOT NULL,
  cita_idcita INTEGER NOT NULL,
  descripcion VARCHAR2(200) NULL,
  fecha DATE NULL,
  valor INTEGER NULL,
  PRIMARY KEY (idmulta),
  --INDEX fk_multa_cita1_idx (cita_idcita ASC),
  CONSTRAINT fk_multa_cita1 FOREIGN KEY (cita_idcita) REFERENCES cita (idcita));

-- -----------------------------------------------------
-- Table copago
-- -----------------------------------------------------
CREATE TABLE copago (
  idcopago INTEGER NOT NULL,
  cita_idcita INTEGER NOT NULL,
  fecha DATE NULL,
  valor INTEGER NULL,
  PRIMARY KEY (idcopago),
  --INDEX fk_copago_cita1_idx (cita_idcita ASC),
  CONSTRAINT fk_copago_cita1 FOREIGN KEY (cita_idcita) REFERENCES cita (idcita));


-- -----------------------------------------------------
-- Table registroclinico
-- -----------------------------------------------------
CREATE TABLE registroclinico (
  idregistroclinico INTEGER NOT NULL,
  cita_idcita INTEGER NOT NULL,
  descripcion VARCHAR2(200) NULL,
  sintomatologia VARCHAR2(200) NULL,
  tratamiento VARCHAR2(200) NULL,
  examenes VARCHAR2(200) NULL,
  observaciones VARCHAR2(200) NULL,
  PRIMARY KEY (idregistroclinico),
  --INDEX fk_registroclinico_cita1_idx (cita_idcita ASC),
  CONSTRAINT fk_registroclinico_cita1 FOREIGN KEY (cita_idcita) REFERENCES cita (idcita));


-- -----------------------------------------------------
-- Table historiaclinica
-- -----------------------------------------------------
CREATE TABLE historiaclinica (
  idhistoriaclinica INTEGER NOT NULL,
  clinico_idregistroclinico INTEGER NOT NULL,
  usuario_idusuario INTEGER NOT NULL,
  PRIMARY KEY (idhistoriaclinica),
  --INDEX fk_historiaclinica_registroclinico1_idx (registroclinico_idregistroclinico ASC),
  --INDEX fk_historiaclinica_usuario1_idx (usuario_idusuario ASC),
  CONSTRAINT fk_hisclinica_regclinico1 FOREIGN KEY (clinico_idregistroclinico) REFERENCES registroclinico (idregistroclinico),
  CONSTRAINT fk_historiaclinica_usuario1 FOREIGN KEY (usuario_idusuario) REFERENCES usuario (idusuario));


-- -----------------------------------------------------
-- Table pagocopago
-- -----------------------------------------------------
CREATE TABLE pagocopago (
  idpagocopago INTEGER NOT NULL,
  copago_idcopago INTEGER NOT NULL,
  fecha DATE NULL,
  PRIMARY KEY (idpagocopago),
  --INDEX fk_pagocopago_copago1_idx (copago_idcopago ASC),
  CONSTRAINT fk_pagocopago_copago1 FOREIGN KEY (copago_idcopago) REFERENCES copago (idcopago));


-- -----------------------------------------------------
-- Table pagomulta
-- -----------------------------------------------------
CREATE TABLE pagomulta (
  idpagomulta INTEGER NOT NULL,
  multa_idmulta INTEGER NOT NULL,
  fecha DATE NULL,
  PRIMARY KEY (idpagomulta),
  --INDEX fk_pagomulta_multa1_idx (multa_idmulta ASC),
  CONSTRAINT fk_pagomulta_multa1 FOREIGN KEY (multa_idmulta) REFERENCES multa (idmulta));


-- -----------------------------------------------------
-- Table curso_has_usuario
-- -----------------------------------------------------
CREATE TABLE curso_has_usuario (
  curso_idcurso INTEGER NOT NULL,
  usuario_idusuario INTEGER NOT NULL,
  PRIMARY KEY (curso_idcurso, usuario_idusuario),
  --INDEX fk_curso_has_usuario_usuario1_idx (usuario_idusuario ASC),
  --INDEX fk_curso_has_usuario_curso1_idx (curso_idcurso ASC),
  CONSTRAINT fk_curso_has_usuario_curso1 FOREIGN KEY (curso_idcurso) REFERENCES curso (idcurso),
  CONSTRAINT fk_curso_has_usuario_usuario1 FOREIGN KEY (usuario_idusuario) REFERENCES usuario (idusuario));


-- -----------------------------------------------------
-- Table consulta
-- -----------------------------------------------------
CREATE TABLE consulta (
  idconsulta INTEGER NOT NULL,
  usuario_idusuario INTEGER NOT NULL,
  descripcion VARCHAR2(200) NULL,
  respuesta VARCHAR2(200) NULL,
  PRIMARY KEY (idconsulta, usuario_idusuario),
  --INDEX fk_consulta_usuario1_idx (usuario_idusuario ASC),
  CONSTRAINT fk_consulta_usuario1 FOREIGN KEY (usuario_idusuario) REFERENCES usuario (idusuario));