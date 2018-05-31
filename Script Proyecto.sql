CREATE SEQUENCE seq_idagenda --nombre de la secuencia
START WITH 4 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo

CREATE TRIGGER trig_idagenda
  BEFORE INSERT ON agenda
  FOR EACH ROW
  BEGIN
    SELECT seq_idagenda.nextval INTO :new.idagenda FROM dual;
END;


CREATE SEQUENCE seq_idusuario --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo

CREATE TRIGGER trig_idusuario
  BEFORE INSERT ON usuario
  FOR EACH ROW
  BEGIN
    SELECT seq_idusuario.nextval INTO :new.idusuario FROM dual;
  END;
  
CREATE SEQUENCE seq_idcita --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo

CREATE TRIGGER trig_idcita
  BEFORE INSERT ON cita
  FOR EACH ROW
  BEGIN
    SELECT seq_idcita.nextval INTO :new.idcita FROM dual;
  END;
  
CREATE SEQUENCE seq_idcopago --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo

CREATE TRIGGER trig_idcopago
  BEFORE INSERT ON copago
  FOR EACH ROW
  BEGIN
    SELECT seq_idcopago.nextval INTO :new.idcopago FROM dual;
  END;
  
CREATE SEQUENCE seq_idcurso --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo

CREATE TRIGGER trig_idcurso
  BEFORE INSERT ON curso
  FOR EACH ROW
  BEGIN
    SELECT seq_idcurso.nextval INTO :new.idcurso FROM dual;
  END;

CREATE SEQUENCE seq_idmedico --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo 

CREATE TRIGGER trig_idmedico
  BEFORE INSERT ON medico
  FOR EACH ROW
  BEGIN
    SELECT seq_idmedico.nextval INTO :new.idmedico FROM dual;
  END;

CREATE SEQUENCE seq_idmulta --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo 

CREATE TRIGGER trig_idmulta
  BEFORE INSERT ON multa
  FOR EACH ROW
  BEGIN
    SELECT seq_idmulta.nextval INTO :new.idmulta FROM dual;
  END;

CREATE SEQUENCE seq_idpagocopago --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo 

CREATE TRIGGER trig_idpagocopago
  BEFORE INSERT ON pagocopago
  FOR EACH ROW
  BEGIN
    SELECT seq_idpagocopago.nextval INTO :new.idpagocopago FROM dual;
  END;
  
CREATE SEQUENCE seq_idpagomulta --nombre de la secuencia
START WITH 1 --la secuencia empieza por 1
INCREMENT BY 1 --se incrementa de uno en uno
NOMAXVALUE; --no tiene valor maximo

CREATE TRIGGER trig_idpagomulta
  BEFORE INSERT ON pagomulta
  FOR EACH ROW
  BEGIN
    SELECT seq_idpagomulta.nextval INTO :new.idpagomulta FROM dual;
  END;




  
INSERT INTO USUARIO(ROLES_IDROLES,CATEGORIA_IDCATEGORIA,NOMBRE,CEDULA,CONTRASENA,CORREO, ACTIVO,INCUMPLIMIENTO) VALUES(1,2,'JUAN',254123,254123,'JUAN@HOTMAIL.COM',1,0);

SELECT USUARIO.IDUSUARIO FROM USUARIO WHERE USUARIO.CORREO='CARLOS@GMAIL.COM' AND USUARIO.CONTRASENA='12345';

DECLARE
    IDENTIFICACION INTEGER;
    PROCEDURE INICIAR_SESION(CORREO IN VARCHAR2, CONTRASENA IN VARCHAR2, IDENTIFICACION OUT INTEGER)
      IS
      VCORREO VARCHAR2(200);
      VCONTRASENA VARCHAR2(200);
      VIDENTIFICACION INTEGER;
      BEGIN
        VCORREO:=CORREO;
        VCONTRASENA:=CONTRASENA;
        SELECT USUARIO.IDUSUARIO INTO VIDENTIFICACION FROM USUARIO WHERE USUARIO.CORREO=VCORREO AND USUARIO.CONTRASENA=VCONTRASENA;
        IDENTIFICACION:=VIDENTIFICACION;
        DBMS_OUTPUT.PUT_LINE(IDENTIFICACION);
      EXCEPTION
        WHEN NO_DATA_FOUND THEN
          VIDENTIFICACION:=-1;
          IDENTIFICACION:=VIDENTIFICACION;
          DBMS_OUTPUT.PUT_LINE(IDENTIFICACION);
    END INICIAR_SESION;
BEGIN
    INICIAR_SESION('CARLOS@GMAIL.COM','12345',IDENTIFICACION);
END;

SET SERVEROUTPUT ON;
  