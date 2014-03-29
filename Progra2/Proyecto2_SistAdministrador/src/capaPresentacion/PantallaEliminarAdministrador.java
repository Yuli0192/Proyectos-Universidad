package capaPresentacion;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Administrador;
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
public class PantallaEliminarAdministrador extends javax.swing.JFrame {
	private JTextField txtBuscar;
	private JLabel BUS;
	private JLabel numIdentificacion;
	private JButton btnRegresar;
	private JButton btnEliminar;
	private JLabel numAdministrador;
	private JTextField txtNumAbogado;
	private JTextField txtNomAdminstrador;
	private JLabel nomAbogado;
	private JButton btnBuscar;
	private Gestor gestor;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaEliminarAdministrador inst = new PantallaEliminarAdministrador();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaEliminarAdministrador() {
		super();
		initGUI();
		gestor= new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setTitle("Eliminar Administrador");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				txtBuscar = new JTextField();
				getContentPane().add(txtBuscar);
				txtBuscar.setBounds(26, 39, 190, 23);
			}
			{
				btnBuscar = new JButton();
				getContentPane().add(btnBuscar);
				btnBuscar.setText("Buscar");
				btnBuscar.setBounds(235, 34, 128, 33);
				btnBuscar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/bus1.gif")));
				btnBuscar.setBackground(new java.awt.Color(255,255,255));
				btnBuscar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnBuscar.actionPerformed, event="+evt);
						//TODO add your code for btnBuscar.actionPerformed
						btnBuscar_actionPerformed(evt);
						
					}

				});
			}
			{
				nomAbogado = new JLabel();
				getContentPane().add(nomAbogado);
				nomAbogado.setText("Nombre Administrador");
				nomAbogado.setBounds(26, 75, 161, 21);
			}
			{
				txtNomAdminstrador = new JTextField();
				getContentPane().add(txtNomAdminstrador);
				txtNomAdminstrador.setBounds(187, 74, 176, 23);
			}
			{
				txtNumAbogado = new JTextField();
				getContentPane().add(txtNumAbogado);
				txtNumAbogado.setBounds(187, 114, 116, 23);
			}

			{
				btnEliminar = new JButton();
				getContentPane().add(btnEliminar);
				btnEliminar.setText("Eliminar");
				btnEliminar.setBounds(26, 174, 130, 35);
				btnEliminar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/modificar3.gif")));
				btnEliminar.setBackground(new java.awt.Color(255,255,255));
				btnEliminar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnEliminar.actionPerformed, event="+evt);
						//TODO add your code for btnEliminar.actionPerformed
						btnEliminar_actionPerformed(evt);
					}

	
				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(235, 174, 128, 35);
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}


				});
			}
			{
				numIdentificacion = new JLabel();
				getContentPane().add(numIdentificacion);
				numIdentificacion.setText("Identificacion");
				numIdentificacion.setBounds(26, 116, 125, 18);
			}
			{
				BUS = new JLabel();
				getContentPane().add(BUS);
				BUS.setText("Buscar por Numero Administrador");
				BUS.setBounds(26, 12, 209, 21);
			}
			pack();
			this.setSize(400, 273);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	

	private void btnBuscar_actionPerformed(ActionEvent evt) {
		
		String numIdentificacion;
		numIdentificacion=txtBuscar.getText();
		Administrador administrador;
		try {
			administrador=gestor.buscarAdministrador(numIdentificacion);
			txtNomAdminstrador.setText(administrador.getNomAdministrador()+"");
			txtNumAbogado.setText(administrador.getNumIdentAdministrador()+"");

		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			txtNomAdminstrador.setText("");
			txtNumAbogado.setText("");

		}
		
	}
	
	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP=new PantallaPrincipal();
		PP.setVisible(true);
		PantallaEliminarAdministrador.this.dispose();		
	}
	
	private void btnEliminar_actionPerformed(ActionEvent evt) {
		String numAbogado;
		
		try {
			numAbogado=txtNumAbogado.getText();
			gestor.borrarAdministrador(numAbogado);
			txtBuscar.setText("");
			txtNumAbogado.setText("");
			numAdministrador.setText("");
			txtNomAdminstrador.setText("");
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			txtNomAdminstrador.setText("Se Elimino el Administrador");
		}
		
	}

}
