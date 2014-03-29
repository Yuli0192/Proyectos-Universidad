package capaPresentacion;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.BorderFactory;
import javax.swing.ImageIcon;
import javax.swing.JButton;

import javax.swing.WindowConstants;
import javax.swing.border.BevelBorder;
import javax.swing.border.SoftBevelBorder;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;
import javax.swing.SwingUtilities;

import capaLogica.Gestor;


/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class PantallaPrincipal extends javax.swing.JFrame {

	{
		//Set Look & Feel
		try {
			javax.swing.UIManager.setLookAndFeel("com.jgoodies.looks.plastic.PlasticLookAndFeel");
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	private JButton btnAgregarAbogado;
	private JButton btnAgregarComunidad;
	private JButton btnModificarComunidad;
	private JButton btnModificarAbogado;
	private JButton btnRegsitrarEmpresa;
	private Gestor gestor;
	private JButton btnRegistrarPropiedad;
	private JButton btnEliminarCuenta;
	private JButton btnEliminarPropiedad;
	private JButton btnEliminarEmpresa;
	private JButton btnEliminarComunidad;
	private JButton btnAgregarSaldo;
	private JButton btnModificarPropiedad;
	private JButton btnRegistrarCuenta;
	private JButton btnRegistrarRecibo;
	private JButton btnEliminarAdministrardor;
	private JButton btnModificarEmpresa;
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaPrincipal inst = new PantallaPrincipal();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaPrincipal() {
		super();
		initGUI();
		gestor= new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(136,196,255));
			this.setTitle("Sistema Administrador de Fincas");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				btnAgregarAbogado = new JButton();
				getContentPane().add(btnAgregarAbogado);
				btnAgregarAbogado.setText("Registrar Administrador");
				btnAgregarAbogado.setBounds(34, 31, 196, 37);
				btnAgregarAbogado.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnAgregarAbogado.setBackground(new java.awt.Color(255,255,255));
				btnAgregarAbogado.setBorder(new SoftBevelBorder(BevelBorder.LOWERED, null, null, null, null));
				btnAgregarAbogado.setForeground(new java.awt.Color(0,128,255));
				btnAgregarAbogado.setDisabledIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/31.ico")));
				btnAgregarAbogado.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregarAbogado.actionPerformed, event="+evt);
						//TODO add your code for btnAgregarAbogado.actionPerformed
						btnAgregarAbogado_actionPerformed(evt);
					}

					private void btnAgregarAbogado_actionPerformed(ActionEvent evt) {
						// TODO Auto-generated method stub
						PantallaRegistarAbogado PRA= new PantallaRegistarAbogado(); 
						PRA.setVisible(true);
						PantallaPrincipal.this.dispose();
					}
				});
			}
			{
				btnAgregarComunidad = new JButton();
				getContentPane().add(btnAgregarComunidad);
				btnAgregarComunidad.setText("Registrar Comunidad");
				btnAgregarComunidad.setBounds(34, 83, 196, 39);
				btnAgregarComunidad.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnAgregarComunidad.setBackground(new java.awt.Color(255,255,255));
				btnAgregarComunidad.setForeground(new java.awt.Color(0,128,255));
				btnAgregarComunidad.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregarComunidad.actionPerformed, event="+evt);
						//TODO add your code for btnAgregarComunidad.actionPerformed
						btnAgregarComunidad_actionPerformed(evt);
					}


				});
			}
			{
				btnRegsitrarEmpresa = new JButton();
				getContentPane().add(btnRegsitrarEmpresa);
				btnRegsitrarEmpresa.setText("Registrar Empresa");
				btnRegsitrarEmpresa.setBounds(34, 139, 196, 38);
				btnRegsitrarEmpresa.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnRegsitrarEmpresa.setBackground(new java.awt.Color(255,255,255));
				btnRegsitrarEmpresa.setForeground(new java.awt.Color(0,128,255));
				btnRegsitrarEmpresa.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegsitrarEmpresa.actionPerformed, event="+evt);
						//TODO add your code for btnRegsitrarEmpresa.actionPerformed
						btnRegsitrarEmpresa_actionPerformed(evt);
					}
				});
			}
			{
				btnModificarAbogado = new JButton();
				getContentPane().add(btnModificarAbogado);
				btnModificarAbogado.setText("Modificar Administrador");
				btnModificarAbogado.setBounds(241, 31, 196, 37);
				btnModificarAbogado.setBackground(new java.awt.Color(255,255,255));
				btnModificarAbogado.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnModificarAbogado.setForeground(new java.awt.Color(0,128,255));
				btnModificarAbogado.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnModificarAbogado.actionPerformed, event="+evt);
						//TODO add your code for btnModificarAbogado.actionPerformed
						btnModificarAbogado_actionPerformed(evt);
					}

				});
			}
			{
				btnModificarComunidad = new JButton();
				getContentPane().add(btnModificarComunidad);
				btnModificarComunidad.setText("Modificar Comunidad");
				btnModificarComunidad.setBounds(241, 84, 196, 38);
				btnModificarComunidad.setBackground(new java.awt.Color(255,255,255));
				btnModificarComunidad.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnModificarComunidad.setForeground(new java.awt.Color(0,128,255));
				btnModificarComunidad.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnModificarComunidad.actionPerformed, event="+evt);
						//TODO add your code for btnModificarComunidad.actionPerformed
						btnModificarComunidad_actionPerformed(evt);
					}
				});
			}
			{
				btnModificarEmpresa = new JButton();
				getContentPane().add(btnModificarEmpresa);
				btnModificarEmpresa.setText("Modificar Empresa");
				btnModificarEmpresa.setBounds(241, 139, 196, 38);
				btnModificarEmpresa.setBackground(new java.awt.Color(255,255,255));
				btnModificarEmpresa.setForeground(new java.awt.Color(0,128,255));
				btnModificarEmpresa.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnModificarEmpresa.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnModificarEmpresa.actionPerformed, event="+evt);
						//TODO add your code for btnModificarEmpresa.actionPerformed 
						btnModificarEmpresa_actionPerformed(evt);
					}

				});
			}
			{
				btnEliminarAdministrardor = new JButton();
				getContentPane().add(btnEliminarAdministrardor);
				btnEliminarAdministrardor.setText("Eliminar Administrador");
				btnEliminarAdministrardor.setBounds(448, 32, 196, 36);
				btnEliminarAdministrardor.setBackground(new java.awt.Color(255,255,255));
				btnEliminarAdministrardor.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnEliminarAdministrardor.setForeground(new java.awt.Color(0,128,255));
				btnEliminarAdministrardor.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnEliminarAdministrardor.actionPerformed, event="+evt);
						//TODO add your code for btnEliminarAdministrardor.actionPerformed
						btnEliminarAdministrardor_actionPerformed(evt);
					}

				});
			}
			{
				btnRegistrarRecibo = new JButton();
				getContentPane().add(btnRegistrarRecibo);
				btnRegistrarRecibo.setText("Registrar Recibo");
				btnRegistrarRecibo.setBounds(34, 293, 196, 43);
				btnRegistrarRecibo.setBackground(new java.awt.Color(255,255,255));
				btnRegistrarRecibo.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnRegistrarRecibo.setForeground(new java.awt.Color(0,128,255));
				btnRegistrarRecibo.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegistrarRecibo.actionPerformed, event="+evt);
						//TODO add your code for btnRegistrarRecibo.actionPerformed PantallaRegsitrarRecibo
						btnRegistrarRecibo_actionPerformed(evt);
					}

				});
			}
			{
				btnRegistrarPropiedad = new JButton();
				getContentPane().add(btnRegistrarPropiedad);
				btnRegistrarPropiedad.setText("Registrar Propiedad");
				btnRegistrarPropiedad.setBounds(34, 192, 196, 40);
				btnRegistrarPropiedad.setBackground(new java.awt.Color(255,255,255));
				btnRegistrarPropiedad.setForeground(new java.awt.Color(0,128,255));
				btnRegistrarPropiedad.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnRegistrarPropiedad.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegistrarPropiedad.actionPerformed, event="+evt);
						//TODO add your code for btnRegistrarPropiedad.actionPerformed
						btnRegistrarPropiedad_actionPerformed(evt);
					}

				});
			}
			{
				btnRegistrarCuenta = new JButton();
				getContentPane().add(btnRegistrarCuenta);
				btnRegistrarCuenta.setText("Registrar Cuenta");
				btnRegistrarCuenta.setBounds(34, 243, 196, 39);
				btnRegistrarCuenta.setBackground(new java.awt.Color(255,255,255));
				btnRegistrarCuenta.setForeground(new java.awt.Color(0,128,255));
				btnRegistrarCuenta.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnRegistrarCuenta.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegistrarCuenta.actionPerformed, event="+evt);
						//TODO add your code for btnRegistrarCuenta.actionPerformed 
						btnRegistrarCuenta_actionPerformed();
					}

				});
			}
			{
				btnModificarPropiedad = new JButton();
				getContentPane().add(btnModificarPropiedad);
				btnModificarPropiedad.setText("Modificar Propiedad");
				btnModificarPropiedad.setBounds(241, 192, 196, 40);
				btnModificarPropiedad.setBackground(new java.awt.Color(255,255,255));
				btnModificarPropiedad.setForeground(new java.awt.Color(0,128,255));
				btnModificarPropiedad.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnModificarPropiedad.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnModificarPropiedad.actionPerformed, event="+evt);
						//TODO add your code for btnModificarPropiedad.actionPerformed
						btnModificarPropiedad_actionPerformed(evt);
					}

				});
			}
			{
				btnAgregarSaldo = new JButton();
				getContentPane().add(btnAgregarSaldo);
				btnAgregarSaldo.setText("Agregar Saldo Cuenta");
				btnAgregarSaldo.setBounds(241, 243, 196, 39);
				btnAgregarSaldo.setBackground(new java.awt.Color(255,255,255));
				btnAgregarSaldo.setForeground(new java.awt.Color(0,128,255));
				btnAgregarSaldo.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnAgregarSaldo.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregarSaldo.actionPerformed, event="+evt);
						//TODO add your code for btnAgregarSaldo.actionPerformed
						btnAgregarSaldo_actionPerformed(evt);
					}
				});
			}
			{
				btnEliminarComunidad = new JButton();
				getContentPane().add(btnEliminarComunidad);
				btnEliminarComunidad.setText("Eliminar Comunidad");
				btnEliminarComunidad.setBounds(448, 84, 196, 38);
				btnEliminarComunidad.setBackground(new java.awt.Color(255,255,255));
				btnEliminarComunidad.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnEliminarComunidad.setForeground(new java.awt.Color(0,128,255));
				btnEliminarComunidad.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnEliminarComunidad.actionPerformed, event="+evt);
						//TODO add your code for btnEliminarComunidad.actionPerformed
						btnEliminarComunidad_actionPerformed();
					}

				});
			}
			{
				btnEliminarEmpresa = new JButton();
				getContentPane().add(btnEliminarEmpresa);
				btnEliminarEmpresa.setText("Eliminar Empresa");
				btnEliminarEmpresa.setBounds(448, 139, 196, 38);
				btnEliminarEmpresa.setBackground(new java.awt.Color(255,255,255));
				btnEliminarEmpresa.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnEliminarEmpresa.setForeground(new java.awt.Color(0,128,255));
			}
			{
				btnEliminarPropiedad = new JButton();
				getContentPane().add(btnEliminarPropiedad);
				btnEliminarPropiedad.setText("Eliminar Propiedad");
				btnEliminarPropiedad.setBounds(448, 192, 196, 40);
				btnEliminarPropiedad.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnEliminarPropiedad.setBackground(new java.awt.Color(255,255,255));
				btnEliminarPropiedad.setForeground(new java.awt.Color(0,128,255));
			}
			{
				btnEliminarCuenta = new JButton();
				getContentPane().add(btnEliminarCuenta);
				btnEliminarCuenta.setText("Eliminar Cuenta");
				btnEliminarCuenta.setBounds(448, 243, 196, 39);
				btnEliminarCuenta.setBackground(new java.awt.Color(255,255,255));
				btnEliminarCuenta.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/save.gif")));
				btnEliminarCuenta.setForeground(new java.awt.Color(0,128,255));
			}
			pack();
			this.setSize(756, 511);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}

	private void btnAgregarComunidad_actionPerformed(ActionEvent evt) {
		PantallaRegistrarComunidad PRC=new PantallaRegistrarComunidad();
		PRC.setVisible(true);
		PantallaPrincipal.this.dispose();
		
	}
	
	private void btnRegsitrarEmpresa_actionPerformed(ActionEvent evt) {
		PantallaRegistrarEmpresa PRE= new PantallaRegistrarEmpresa();
		PRE.setVisible(true);
		PantallaPrincipal.this.dispose();
	}
	
	private void btnModificarAbogado_actionPerformed(ActionEvent evt) {
		PantallaModificarAbogado PR=new PantallaModificarAbogado();
		PR.setVisible(true);
		PantallaPrincipal.this.dispose();	
	}
	
	private void btnModificarComunidad_actionPerformed(ActionEvent evt) {
		PantallaModificarComunidad PMC= new PantallaModificarComunidad();
		PMC.setVisible(true);
		PantallaPrincipal.this.dispose();
	}

	private void btnModificarEmpresa_actionPerformed(ActionEvent evt) {
		PantallaModificarEmpresa PME =new PantallaModificarEmpresa();
		PME.setVisible(true);
		PantallaPrincipal.this.dispose();
	}

	private void btnEliminarAdministrardor_actionPerformed(ActionEvent evt) {
		PantallaEliminarAdministrador PEA= new PantallaEliminarAdministrador();
		PEA.setVisible(true);
		PantallaPrincipal.this.dispose();
	}
	

	private void btnRegistrarRecibo_actionPerformed(ActionEvent evt) {
		PantallaRegsitrarRecibo PRR=new PantallaRegsitrarRecibo();
		PRR.setVisible(true);
		PantallaPrincipal.this.dispose();
	}


	private void btnRegistrarPropiedad_actionPerformed(ActionEvent evt) {
		PantallaRegistrarPropiedad PRP = new PantallaRegistrarPropiedad();
		PRP.setVisible(true);
		PantallaPrincipal.this.dispose();
	}
	

	private void btnRegistrarCuenta_actionPerformed() {
		PantallaRegistrarCuenta PRC=new PantallaRegistrarCuenta();
		PRC.setVisible(true);
		PantallaPrincipal.this.dispose();
	}

	private void btnModificarPropiedad_actionPerformed(ActionEvent evt) {
		PantallaModificarPropiedad PMP=new PantallaModificarPropiedad();
		PMP.setVisible(true);
		PantallaPrincipal.this.dispose();
		
	}

	private void btnAgregarSaldo_actionPerformed(ActionEvent evt) {
		PantallaAgregarSaldoCuenta PASC=new  PantallaAgregarSaldoCuenta();
		PASC.setVisible(true);
		PantallaPrincipal.this.dispose();
		
	}

	private void btnEliminarComunidad_actionPerformed() {
		PantallaEliminarComunidad PEC=new PantallaEliminarComunidad();
		PEC.setVisible(true);
		PantallaPrincipal.this.dispose();
	}

}
