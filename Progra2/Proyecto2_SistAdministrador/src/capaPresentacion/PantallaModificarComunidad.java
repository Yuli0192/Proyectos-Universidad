package capaPresentacion;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Administrador;
import capaLogica.Comunidad;
import capaLogica.Gestor;
import capaLogica.MultiComunidad;


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
public class PantallaModificarComunidad extends javax.swing.JFrame {
	private JTextField txtBusqueda;
	private JButton btnBusqueda;
	private JLabel bus;
	private JLabel nomAbogado;
	private JTextField txtNomAbogado;
	private Gestor gestor;
	private JLabel codPostal;
	private JButton btnRegresar;
	private JButton btnModificar;
	private JLabel nomComunidad;
	private JTextField txtNomComunidad;
	private JTextField txtCodPostal;
	private JLabel cantPoblacion;
	private JTextField txtCantPoblacion;
	private JLabel numComunidad;
	private JTextField txtNumComunidad;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaModificarComunidad inst = new PantallaModificarComunidad();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaModificarComunidad() {
		super();
		initGUI();
		gestor=new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setTitle("Modificar Comunidad");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				txtBusqueda = new JTextField();
				getContentPane().add(txtBusqueda);
				txtBusqueda.setBounds(27, 40, 243, 23);
			}
			{
				btnBusqueda = new JButton();
				getContentPane().add(btnBusqueda);
				btnBusqueda.setText("Buscar");
				btnBusqueda.setBounds(282, 35, 133, 34);
				btnBusqueda.setBackground(new java.awt.Color(255,255,255));
				btnBusqueda.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/bus1.gif")));
				btnBusqueda.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnBusqueda.actionPerformed, event="+evt);
						//TODO add your code for btnBusqueda.actionPerformed
						btnBusqueda_actionPerformed(evt);
					}

				});
			}
			{
				txtNumComunidad = new JTextField();
				getContentPane().add(txtNumComunidad);
				txtNumComunidad.setEditable(false);
				txtNumComunidad.setBounds(175, 91, 114, 23);
			}
			{
				numComunidad = new JLabel();
				getContentPane().add(numComunidad);
				numComunidad.setText("Numero Comunidad");
				numComunidad.setBounds(27, 94, 124, 16);
			}
			{
				txtCantPoblacion = new JTextField();
				getContentPane().add(txtCantPoblacion);
				txtCantPoblacion.setBounds(175, 126, 114, 23);
			}
			{
				cantPoblacion = new JLabel();
				getContentPane().add(cantPoblacion);
				cantPoblacion.setText("Cantidad Poblacion");
				cantPoblacion.setBounds(27, 129, 148, 20);
			}
			{
				txtCodPostal = new JTextField();
				getContentPane().add(txtCodPostal);
				txtCodPostal.setBounds(175, 169, 114, 24);
			}
			{
				codPostal = new JLabel();
				getContentPane().add(codPostal);
				codPostal.setText("Codigo Postal");
				codPostal.setBounds(27, 170, 124, 21);
			}
			{
				txtNomComunidad = new JTextField();
				getContentPane().add(txtNomComunidad);
				txtNomComunidad.setBounds(175, 208, 240, 23);
			}
			{
				nomComunidad = new JLabel();
				getContentPane().add(nomComunidad);
				nomComunidad.setText("Nombre");
				nomComunidad.setBounds(27, 211, 124, 16);
			}
			{
				btnModificar = new JButton();
				getContentPane().add(btnModificar);
				btnModificar.setText("Modificar");
				btnModificar.setBounds(27, 292, 165, 40);
				btnModificar.setBackground(new java.awt.Color(255,255,255));
				btnModificar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/modificar.gif")));
				btnModificar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnModificar.actionPerformed, event="+evt);
						//TODO add your code for btnModificar.actionPerformed
						btnModificar_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(259, 292, 156, 40);
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
				nomAbogado = new JLabel();
				getContentPane().add(nomAbogado);
				nomAbogado.setText("Nombre Administrador");
				nomAbogado.setBounds(27, 248, 147, 20);
			}
			{
				txtNomAbogado = new JTextField();
				getContentPane().add(txtNomAbogado);
				txtNomAbogado.setBounds(174, 247, 241, 23);
			}
			{
				bus = new JLabel();
				getContentPane().add(bus);
				bus.setText("Buscar por numero Comunidad");
				bus.setBounds(27, 12, 243, 22);
			}
			pack();
			this.setSize(472, 398);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}


	private void btnBusqueda_actionPerformed(ActionEvent evt) {
		Comunidad comunidad;
		String numComunidad,numAdministrador;
		Administrador administrador;
		numComunidad=txtBusqueda.getText();
		
		//txtNumComunidad.setText(numComunidad);
		try {		
			comunidad=gestor.buscarComunidad(numComunidad);
			txtNumComunidad.setText(comunidad.getNumComunidad()+"");
			txtCantPoblacion.setText(comunidad.getCantPoblacion()+"");
			txtCodPostal.setText(comunidad.getCodPostalComunidad()+"");
			txtNomComunidad.setText(comunidad.getNomComunidad()+"");
			numAdministrador=comunidad.getNomAbogado();
			administrador=gestor.buscarAdministrador(numAdministrador);	
			txtNomAbogado.setText(administrador.getNomAdministrador()+"");
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			//txtNumComunidad.setText("no sirve");
		}	
	}

	private void btnModificar_actionPerformed(ActionEvent evt) {
		String numComunidad,nomcomunidad,codPostal,mjs,nomAbogado;
		int cantPoblacion;
		numComunidad=txtNumComunidad.getText();
		nomcomunidad=txtNomComunidad.getText();
		codPostal=txtCodPostal.getText();
		cantPoblacion=Integer.parseInt(txtCantPoblacion.getText());
		nomAbogado=txtNomAbogado.getText();
		mjs=gestor.modificarCuidad(numComunidad, nomcomunidad, codPostal, cantPoblacion, nomAbogado);
		JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
		txtNumComunidad.setText("");
		txtNomComunidad.setText("");
		txtCodPostal.setText("");
		txtCantPoblacion.setText("");
		txtBusqueda.setText("");
		txtNomAbogado.setText("");
	}
	

	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP=new PantallaPrincipal();
		PP.setVisible(true);
		PantallaModificarComunidad.this.dispose();
		
	}
}
