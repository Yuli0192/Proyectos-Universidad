package capaPresentacion;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;

import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Administrador;
import capaLogica.Gestor;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

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
public class PantallaRegistrarComunidad extends javax.swing.JFrame {
	private JTextField txtNumComunidad;
	private JLabel codPostal;
	private JButton btnAgregar;
	private JComboBox cbxListaAbogados;
	private JLabel numAdministrador;
	private JButton btnRegresar;
	private JLabel nomComunidad;
	private JTextField txtNomComunidad;
	private JTextField txtCodPostal;
	private JTextField txtCantPoblacion;
	private JLabel cantPoblacion;
	private JLabel numComunidad;
	private Gestor gestor;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaRegistrarComunidad inst = new PantallaRegistrarComunidad();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
				
			}
		});
	}
	
	public PantallaRegistrarComunidad() {
		super();
		initGUI();
		gestor=new Gestor();
		cargarDatosAbogados();
	}
	private void cargarDatosAbogados() {
		String [] listaAbogados = gestor.obtenerAdministradorIds();
		for(int i=0; i<listaAbogados.length;i++){
			cbxListaAbogados.addItem(listaAbogados[i]);		
		}
	}

	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setTitle("Registrar Comunidad");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				txtNumComunidad = new JTextField();
				getContentPane().add(txtNumComunidad);
				txtNumComunidad.setBounds(157, 49, 130, 23);
			}
			{
				numComunidad = new JLabel();
				getContentPane().add(numComunidad);
				numComunidad.setText("Numero Comunidad");
				numComunidad.setBounds(29, 49, 158, 23);
			}
			{
				cantPoblacion = new JLabel();
				getContentPane().add(cantPoblacion);
				cantPoblacion.setText("Cantidad Poblacion");
				cantPoblacion.setBounds(29, 92, 158, 17);
			}
			{
				txtCantPoblacion = new JTextField();
				getContentPane().add(txtCantPoblacion);
				txtCantPoblacion.setBounds(157, 89, 130, 23);
			}
			{
				txtCodPostal = new JTextField();
				getContentPane().add(txtCodPostal);
				txtCodPostal.setBounds(158, 128, 130, 23);
			}
			{
				codPostal = new JLabel();
				getContentPane().add(codPostal);
				codPostal.setText("Codigo Postal");
				codPostal.setBounds(29, 131, 151, 16);
			}
			{
				txtNomComunidad = new JTextField();
				getContentPane().add(txtNomComunidad);
				txtNomComunidad.setBounds(157, 171, 221, 23);
			}
			{
				nomComunidad = new JLabel();
				getContentPane().add(nomComunidad);
				nomComunidad.setText("Nombre");
				nomComunidad.setBounds(29, 171, 116, 23);
			}
			{
				numAdministrador = new JLabel();
				getContentPane().add(numAdministrador);
				numAdministrador.setText("Adminstrador");
				numAdministrador.setBounds(29, 18, 128, 16);
			}
			{
				ComboBoxModel cbxListaAbogadosModel = new DefaultComboBoxModel(new String[] {  });
				cbxListaAbogados = new JComboBox();
				getContentPane().add(cbxListaAbogados);
				cbxListaAbogados.setModel(cbxListaAbogadosModel);
				cbxListaAbogados.setBounds(157, 12, 221, 23);
				cbxListaAbogados.setBackground(new java.awt.Color(255,255,255));
			}
			{
				btnAgregar = new JButton();
				getContentPane().add(btnAgregar);
				btnAgregar.setText("Agregar");
				btnAgregar.setBounds(29, 224, 137, 37);
				btnAgregar.setBackground(new java.awt.Color(255,255,255));
				btnAgregar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/dis.gif")));
				btnAgregar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregar.actionPerformed, event="+evt);
						//TODO add your code for btnAgregar.actionPerformed
						btnAgregar_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(241, 223, 137, 38);
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
			pack();
			this.setSize(427, 321);
		} catch (Exception e) {}
		
	}


	private void btnAgregar_actionPerformed(ActionEvent evt) {
		String nomAbogado,numComunidad,nomComunidad,codPostalComunidad,mjs,numIdentifiAdministrador,numAbogado;
		int cantPoblacion;
		Administrador administrador;
		try {
			numComunidad=txtNumComunidad.getText();
			nomComunidad=txtNomComunidad.getText();	
			codPostalComunidad=txtCodPostal.getText();
			cantPoblacion=Integer.parseInt(txtCantPoblacion.getText());
			numIdentifiAdministrador= (String) cbxListaAbogados.getSelectedItem();
			
			mjs=gestor.AgregarComunidad(numComunidad,nomComunidad,codPostalComunidad,numIdentifiAdministrador,cantPoblacion);
			JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
			txtNumComunidad.setText("");
			txtNomComunidad.setText("");
			txtCodPostal.setText("");
			txtCantPoblacion.setText("");
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP= new PantallaPrincipal();
		PP.setVisible(true);
		PantallaRegistrarComunidad.this.dispose();
		
		
	}

}
